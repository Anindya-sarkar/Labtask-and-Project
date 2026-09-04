using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Main_project.Models;

namespace Main_project
{
    public static class DatabaseHelper
    {
        
        private static string connectionString = @"Data Source= DESKTOP-8MLGHQM\SQLEXPRESS;Initial Catalog=FoodSafetyDB;Integrated Security=True;";

       
        
        
        public static bool VerifyConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database Connection Failed: " + ex.Message);
                return false;
            }
        }

        
        // METHOD 1: AUTHENTICATION (UPDATED to fetch new User fields)
        
        public static User AuthenticateUser(string username, string password)
        {
            User loggedInUser = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE Username = @user AND Password = @pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    loggedInUser = new User(
                        Convert.ToInt32(reader["UserID"]),
                        reader["FirstName"].ToString(),
                        reader["Username"].ToString(),
                        reader["Gender"].ToString(),
                        reader["Age"] != DBNull.Value ? Convert.ToInt32(reader["Age"]) : 0, // Prevents crash if Age is empty
                        reader["Email"].ToString(),
                        reader["Password"].ToString(),
                        reader["Role"].ToString()
                    );
                }
            }
            return loggedInUser;
        }

        
        // METHOD 2: SEARCH FOODS 
        
        public static List<Food> SearchFoods(string keyword)
        {
            List<Food> foodList = new List<Food>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Foods WHERE FoodName LIKE @keyword OR Category LIKE @keyword";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Food food = new Food(
                        Convert.ToInt32(reader["FoodID"]),
                        reader["FoodName"].ToString(),
                        reader["Category"].ToString(),
                        reader["SafetyStatus"].ToString()
                    );
                    foodList.Add(food);
                }
            }
            return foodList;
        }

       
        // METHOD 3: SUBMIT COMPLAINT (UPDATED to use Complaint object and new Vendor fields)
        
        public static bool SubmitComplaint(Complaint complaint)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Complaints (UserID, Username, FoodItemName, VendorName, VendorID, DetailComplaint, Status, AdminResponse, DateSubmitted) 
                                     VALUES (@UserID, @Username, @FoodItemName, @VendorName, @VendorID, @DetailComplaint, @Status, @AdminResponse, @DateSubmitted)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    // We pass values from the object directly into SQL
                    cmd.Parameters.AddWithValue("@UserID", complaint.UserID);
                    cmd.Parameters.AddWithValue("@Username", complaint.Username ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@FoodItemName", complaint.FoodItemName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@VendorName", string.IsNullOrWhiteSpace(complaint.VendorName) ? (object)DBNull.Value : complaint.VendorName);
                    cmd.Parameters.AddWithValue("@VendorID", string.IsNullOrWhiteSpace(complaint.VendorID) ? (object)DBNull.Value : complaint.VendorID);
                    cmd.Parameters.AddWithValue("@DetailComplaint", complaint.DetailComplaint ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Status", string.IsNullOrWhiteSpace(complaint.Status) ? "Pending" : complaint.Status);
                    cmd.Parameters.AddWithValue("@AdminResponse", string.IsNullOrWhiteSpace(complaint.AdminResponse) ? (object)DBNull.Value : complaint.AdminResponse);
                    cmd.Parameters.AddWithValue("@DateSubmitted", complaint.DateSubmitted == default ? DateTime.Now : complaint.DateSubmitted);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch
            {
                return false;
            }
        }

       
        // METHOD 4: GET ALL ADDITIVES 
        
        public static List<Additive> GetAllAdditives()
        {
            List<Additive> additiveList = new List<Additive>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Additives";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Additive additive = new Additive(
                        Convert.ToInt32(reader["AdditiveID"]),
                        reader["AdditiveName"].ToString(),
                        reader["Category"].ToString(),
                        reader["INSNumber"].ToString(),
                        reader["MaxLimit"].ToString(),
                        reader["RiskInfo"].ToString()
                    );
                    additiveList.Add(additive);
                }
            }
            return additiveList;
        }

        
        // METHOD 5: GET INCIDENTS ARCHIVE
        
        public static List<Incident> GetIncidents()
        {
            List<Incident> incidentList = new List<Incident>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Incidents ORDER BY IncidentDate DESC";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Incident incident = new Incident(
                        Convert.ToInt32(reader["IncidentID"]),
                        reader["Title"].ToString(),
                        reader["Location"].ToString(),
                        reader["IncidentDate"].ToString(),
                        reader["FoodCategory"].ToString(),
                        reader["ViolationType"].ToString(),
                        reader["Status"].ToString()
                    );
                    incidentList.Add(incident);
                }
            }
            return incidentList;
        }

        
        // METHOD 6: UPDATE COMPLAINT STATUS 
        
        public static bool UpdateComplaintStatus(int complaintId, string status, string adminResponse)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Complaints SET Status = @status, AdminResponse = @response WHERE ComplaintID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@response", adminResponse);
                    cmd.Parameters.AddWithValue("@id", complaintId);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch
            {
                return false;
            }
        }

      
        // METHOD 7: CALCULATE CATEGORY SAFETY SCORE 
        
        public static double CalculateCategorySafetyScore(string category)
        {
            int totalItems = 0;
            int safeItems = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT SafetyStatus FROM Foods WHERE Category = @category";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@category", category);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    totalItems++;
                    if (reader["SafetyStatus"].ToString() == "Safe")
                    {
                        safeItems++;
                    }
                }
            }

            if (totalItems == 0) return 0;
            return Math.Round((double)safeItems / totalItems * 100, 2);
        }

        
        // METHOD 8: SIGN UP / REGISTER USER (UPDATED to accept the User object)
        
        public static bool RegisterUser(User user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Users (FirstName, Username, Gender, Age, Email, Password, Role) 
                                     VALUES (@FirstName, @Username, @Gender, @Age, @Email, @Password, @Role)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@FirstName", string.IsNullOrWhiteSpace(user.FirstName) ? (object)DBNull.Value : user.FirstName);
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Gender", string.IsNullOrWhiteSpace(user.Gender) ? (object)DBNull.Value : user.Gender);
                    cmd.Parameters.AddWithValue("@Age", user.Age);
                    cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(user.Email) ? (object)DBNull.Value : user.Email);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Role", string.IsNullOrWhiteSpace(user.Role) ? "User" : user.Role);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        
        // METHOD 9: GET USER COMPLAINT HISTORY (UPDATED mapping for new Vendor fields)
 
        public static List<Complaint> GetUserComplaints(int userId)
        {
            List<Complaint> list = new List<Complaint>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Complaints WHERE UserID = @userId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Complaint(
                        Convert.ToInt32(reader["ComplaintID"]),
                        Convert.ToInt32(reader["UserID"]),
                        reader["Username"].ToString(),
                        reader["FoodItemName"].ToString(),
                        reader["VendorName"].ToString(),
                        reader["VendorID"].ToString(),
                        reader["DetailComplaint"].ToString(),
                        reader["Status"].ToString(),
                        reader["AdminResponse"].ToString()
                    ));
                }
            }
            return list;
        }

       
        // METHOD 10: GET ALL COMPLAINTS (UPDATED mapping for new Vendor fields)
    
        public static List<Complaint> GetAllComplaints()
        {
            List<Complaint> list = new List<Complaint>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Complaints";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Complaint(
                        Convert.ToInt32(reader["ComplaintID"]),
                        Convert.ToInt32(reader["UserID"]),
                        reader["Username"].ToString(),
                        reader["FoodItemName"].ToString(),
                        reader["VendorName"].ToString(),
                        reader["VendorID"].ToString(),
                        reader["DetailComplaint"].ToString(),
                        reader["Status"].ToString(),
                        reader["AdminResponse"].ToString()
                    ));
                }
            }
            return list;
        }

        
        // METHOD 11: ADD NEW FOOD ITEM 
        
        public static bool AddFood(string foodName, string category, string safetyStatus)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Foods (FoodName, Category, SafetyStatus) VALUES (@name, @cat, @status)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", foodName);
                    cmd.Parameters.AddWithValue("@cat", category);
                    cmd.Parameters.AddWithValue("@status", safetyStatus);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        
        // METHOD 12: DELETE FOOD ITEM
     
        public static bool DeleteFood(int foodId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Foods WHERE FoodID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", foodId);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        
        // METHOD 13: GET ALL USERS (UPDATED mapping for new Sign-up fields)
        
        public static List<User> GetAllUsers()
        {
            List<User> list = new List<User>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new User(
                        Convert.ToInt32(reader["UserID"]),
                        reader["FirstName"].ToString(),
                        reader["Username"].ToString(),
                        reader["Gender"].ToString(),
                        reader["Age"] != DBNull.Value ? Convert.ToInt32(reader["Age"]) : 0,
                        reader["Email"].ToString(),
                        reader["Password"].ToString(),
                        reader["Role"].ToString()
                    ));
                }
            }
            return list;
        }
    }
}