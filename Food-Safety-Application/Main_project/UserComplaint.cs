using System;
using System.Windows.Forms;
using Main_project.Models;

namespace Main_project
{
    public partial class UserComplaint : Form
    {
        public UserComplaint()
        {
            InitializeComponent();
            {
                this.ComplaintPage_submitBt.Click += new System.EventHandler(this.ComplaintPage_submitBt_Click);
                this.ComplaintPage_CancelBt.Click += new System.EventHandler(this.ComplaintPage_CancelBt_Click);
            }
        }

        private void UserComplaint_Load(object sender, EventArgs e)
        {
        }

        private void ComplaintPage_submitBt_Click(object sender, EventArgs e)
        {
            // Check if user is logged in
            if (!SessionManager.IsUserLoggedIn)
            {
                MessageBox.Show("You must be logged in to submit a complaint.", "Not Logged In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Extract values using exact control names
            string username = ComplaintPage_usernameTB.Text.Trim();
            string foodItem = ComplaintPage_FoodItemTB.Text.Trim();
            string vendorName = ComplaintPage_VendorNameTB.Text.Trim();
            string vendorId = ComplaintPage_VendorIdTB.Text.Trim();
            string details = ComplaintPage_DetailsTB.Text.Trim();

            // Validation check to ensure all fields are filled
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(foodItem) ||
                string.IsNullOrEmpty(vendorName) || string.IsNullOrEmpty(vendorId) ||
                string.IsNullOrEmpty(details))
            {
                MessageBox.Show("Please fill out all required fields before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create complaint object
            Complaint complaint = new Complaint(
                0,
                SessionManager.CurrentUser.ID,
                SessionManager.CurrentUser.Username,
                foodItem,
                vendorName,
                vendorId,
                details,
                "Pending",
                ""
            );

            // Submit complaint to database
            if (DatabaseHelper.SubmitComplaint(complaint))
            {
                MessageBox.Show($"Complaint filed successfully!\n\nThank you for reporting this issue. We will review and respond shortly.", "Submission Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Return to User Page
                User_Page userPage = new User_Page();
                userPage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to submit complaint. Please try again.", "Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComplaintPage_CancelBt_Click(object sender, EventArgs e)
        {
            // Return to User Page on cancel
            User_Page userPage = new User_Page();
            userPage.Show();
            this.Close();
        }
    }
}