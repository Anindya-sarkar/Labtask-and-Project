using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_project.Models
{
    // Inherits ID from FoodSafetyEntity
    public class Complaint : FoodSafetyEntity
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string FoodItemName { get; set; }
        public string VendorName { get; set; }
        public string VendorID { get; set; }
        public string DetailComplaint { get; set; }
        public string Status { get; set; }
        public string AdminResponse { get; set; }
        public DateTime DateSubmitted { get; set; }

        public Complaint() : base()
        {
            this.Status = "Pending";
            this.DateSubmitted = DateTime.Now;
        }

        public Complaint(int id, int userId, string username, string foodItemName, string vendorName, string vendorID, string detailComplaint, string status = "Pending", string adminResponse = "") : base(id)
        {
            this.UserID = userId;
            this.Username = username;
            this.FoodItemName = foodItemName;
            this.VendorName = vendorName;
            this.VendorID = vendorID;
            this.DetailComplaint = detailComplaint;
            this.Status = status;
            this.AdminResponse = adminResponse;
            this.DateSubmitted = DateTime.Now;
        }
    }
}
