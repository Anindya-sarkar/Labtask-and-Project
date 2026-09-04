using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Main_project.Models;

namespace Main_project
{
    public partial class User_Page : Form
    {
        public User_Page()
        {
            InitializeComponent();
            {
                this.button1.Click += new System.EventHandler(this.button1_Click);
                this.button2.Click += new System.EventHandler(this.button2_Click);
                this.U_Page_Searchbt.Click += new System.EventHandler(this.U_Page_Searchbt_Click);
                this.U_Page_CheckFoodItemsBt.Click += new System.EventHandler(this.U_Page_CheckFoodItemsBt_Click);
                this.U_Page_SubmitComplaintBt.Click += new System.EventHandler(this.U_Page_SubmitComplaintBt_Click);
                this.U_Page_HistoryBt.Click += new System.EventHandler(this.U_Page_HistoryBt_Click);
                this.U_Page_LogOutBt.Click += new System.EventHandler(this.U_Page_LogOutBt_Click);
                this.U_Page_BackBt.Click += new System.EventHandler(this.U_Page_BackBt_Click);
                this.U_Page_NextBt.Click += new System.EventHandler(this.U_Page_NextBt_Click);
                this.UP_searchpnl_searchBt.Click += new System.EventHandler(this.UP_searchpnl_searchBt_Click);
                this.UP_searchpnl_CancelBt.Click += new System.EventHandler(this.UP_searchpnl_CancelBt_Click);
                this.Userpage_textbar_Timer.Tick += new System.EventHandler(this.Userpage_textbar_Timer_Tick);
            }
        }

        private void User_Page_Load(object sender, EventArgs e)
        {
            // Hide search panel by default on load
            Up_searchpanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // My Profile Button Logic
            MessageBox.Show("Opening My Profile...", "Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Dashboard Button Logic (Toggle Panel Visibility)
            Userpage_DBpanel.Visible = !Userpage_DBpanel.Visible;
        }

        private void U_Page_Searchbt_Click(object sender, EventArgs e)
        {
            // Show Search Panel
            Up_searchpanel.Visible = true;
            Up_searchpanel.BringToFront();
        }

        private void U_Page_SubmitComplaintBt_Click(object sender, EventArgs e)
        {
            // Open Complaint Form
            UserComplaint complaintForm = new UserComplaint();
            complaintForm.Show();
            this.Hide();
        }

        private void U_Page_CheckFoodItemsBt_Click(object sender, EventArgs e)
        {
            // Display all food items
            List<Food> allFoods = DatabaseHelper.SearchFoods("");
            
            if (allFoods.Count == 0)
            {
                MessageBox.Show("No food items found in the database.", "Food Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string foodList = "Available Food Items:\n\n";
            foreach (Food food in allFoods)
            {
                foodList += $"• {food.FoodName} (Category: {food.Category}) - Status: {food.SafetyStatus}\n";
            }

            MessageBox.Show(foodList, "Food Items List", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void U_Page_HistoryBt_Click(object sender, EventArgs e)
        {
            // Display user's complaint history
            if (!SessionManager.IsUserLoggedIn)
            {
                MessageBox.Show("You must be logged in to view history.", "Not Logged In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Complaint> userComplaints = DatabaseHelper.GetUserComplaints(SessionManager.CurrentUser.ID);

            if (userComplaints.Count == 0)
            {
                MessageBox.Show("You have no complaints on record.", "Complaint History", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string historyText = "Your Complaint History:\n\n";
            foreach (Complaint complaint in userComplaints)
            {
                historyText += $"Food: {complaint.FoodItemName}\n";
                historyText += $"Vendor: {complaint.VendorName} (ID: {complaint.VendorID})\n";
                historyText += $"Status: {complaint.Status}\n";
                historyText += $"Details: {complaint.DetailComplaint}\n";
                if (!string.IsNullOrEmpty(complaint.AdminResponse))
                {
                    historyText += $"Admin Response: {complaint.AdminResponse}\n";
                }
                historyText += "---\n";
            }

            MessageBox.Show(historyText, "Complaint History", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void U_Page_LogOutBt_Click(object sender, EventArgs e)
        {
            // Log Out Logic: Return to Homepage
            SessionManager.Logout();
            Homepage home = new Homepage();
            home.Show();
            this.Close();
        }

        private void U_Page_BackBt_Click(object sender, EventArgs e)
        {
            // Back Button Logic
        }

        private void U_Page_NextBt_Click(object sender, EventArgs e)
        {
            // Next Button Logic
        }

        private void UP_searchpnl_searchBt_Click(object sender, EventArgs e)
        {
            string query = SearchTB.Text.Trim();
            string category = "";

            if (FoodRB.Checked)
            {
                category = "Food";
            }
            else if (AdditivesRB.Checked)
            {
                category = "Additives";
            }

            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please select an item category (Food or Additives).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Please type an item name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (category == "Food")
            {
                List<Food> searchResults = DatabaseHelper.SearchFoods(query);

                if (searchResults.Count == 0)
                {
                    MessageBox.Show($"No food items found matching '{query}'.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string results = $"Search Results for '{query}':\n\n";
                foreach (Food food in searchResults)
                {
                    results += $"• {food.FoodName}\n  Category: {food.Category}\n  Safety Status: {food.SafetyStatus}\n\n";
                }

                MessageBox.Show(results, "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (category == "Additives")
            {
                List<Additive> allAdditives = DatabaseHelper.GetAllAdditives();
                List<Additive> filteredAdditives = new List<Additive>();

                // Filter additives by search query
                foreach (Additive additive in allAdditives)
                {
                    if (additive.AdditiveName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        filteredAdditives.Add(additive);
                    }
                }

                if (filteredAdditives.Count == 0)
                {
                    MessageBox.Show($"No additives found matching '{query}'.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string results = $"Search Results for '{query}':\n\n";
                foreach (Additive additive in filteredAdditives)
                {
                    results += $"• {additive.AdditiveName}\n  INS Number: {additive.INSNumber}\n  Max Limit: {additive.MaxLimit}\n  Risk: {additive.RiskInfo}\n\n";
                }

                MessageBox.Show(results, "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UP_searchpnl_CancelBt_Click(object sender, EventArgs e)
        {
            // Reset search controls and hide panel
            SearchTB.Clear();
            FoodRB.Checked = false;
            AdditivesRB.Checked = false;
            Up_searchpanel.Visible = false;
        }

        private void Userpage_textbar_Timer_Tick(object sender, EventArgs e)
        {
            // Timer animation/ticker logic
        }

        private void U_Page_SubmitComplaintBt_Click_1(object sender, EventArgs e)
        {

        }
    }
}