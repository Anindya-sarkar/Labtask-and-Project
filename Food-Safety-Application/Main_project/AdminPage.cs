using System;
using System.Windows.Forms;

namespace Main_project
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            {
                this.button1.Click += new System.EventHandler(this.button1_Click);
                this.button2.Click += new System.EventHandler(this.button2_Click);
                this.A_Page_manageFoodBt.Click += new System.EventHandler(this.A_Page_manageFoodBt_Click);
                this.A_Page_manageAdditivesBt.Click += new System.EventHandler(this.A_Page_manageAdditivesBt_Click);
                this.A_Page_manageRulesLawsBt.Click += new System.EventHandler(this.A_Page_manageRulesLawsBt_Click);
                this.A_Page_manageComplaintsBt.Click += new System.EventHandler(this.A_Page_manageComplaintsBt_Click);
                this.A_Page_manageUsersBt.Click += new System.EventHandler(this.A_Page_manageUsersBt_Click);
                this.A_Page_LogOutBt.Click += new System.EventHandler(this.A_Page_LogOutBt_Click);
                this.A_Page_BackBt.Click += new System.EventHandler(this.A_Page_BackBt_Click);
                this.A_Page_NextBt.Click += new System.EventHandler(this.A_Page_NextBt_Click);
            }
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            // Hide dashboard side panel on form load
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Toggle Dashboard side panel visibility
            panel1.Visible = !panel1.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Displaying Admin Profile details.", "Admin Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void A_Page_manageFoodBt_Click(object sender, EventArgs e)
        {
            AdminFoodManagement foodMgmt = new AdminFoodManagement();
            foodMgmt.Show();
            this.Hide();
        }

        private void A_Page_manageAdditivesBt_Click(object sender, EventArgs e)
        {
            AdminAdditivesManagement additiveMgmt = new AdminAdditivesManagement();
            additiveMgmt.Show();
            this.Hide();
        }

        private void A_Page_manageRulesLawsBt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rules & Laws Management - Display database records of food safety regulations.", "Manage Rules & Laws", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void A_Page_manageComplaintsBt_Click(object sender, EventArgs e)
        {
            AdminComplaintsManagement complaintMgmt = new AdminComplaintsManagement();
            complaintMgmt.Show();
            this.Hide();
        }

        private void A_Page_manageUsersBt_Click(object sender, EventArgs e)
        {
            AdminUsersManagement userMgmt = new AdminUsersManagement();
            userMgmt.Show();
            this.Hide();
        }

        private void A_Page_LogOutBt_Click(object sender, EventArgs e)
        {
            SessionManager.Logout();
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Close();
        }

        private void A_Page_BackBt_Click(object sender, EventArgs e)
        {
            // Navigate back to main admin dashboard
            panel1.Visible = false;
        }

        private void A_Page_NextBt_Click(object sender, EventArgs e)
        {
            // Navigate to next page/section
            panel1.Visible = true;
        }
    }
}