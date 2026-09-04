using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Main_project.Models;

namespace Main_project
{
    public partial class AdminComplaintsManagement : Form
    {
        private List<Complaint> complaints = new List<Complaint>();

        public AdminComplaintsManagement()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.AdminComplaintsManagement_Load);
            this.SuspendLayout();
            
            Label titleLabel = new Label() { Text = "Manage Complaints", Left = 20, Top = 20, Width = 300, Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold) };
            
            ListBox complaintsListBox = new ListBox() { Name = "ComplaintsListBox", Left = 20, Top = 60, Width = 400, Height = 200 };
            complaintsListBox.SelectedIndexChanged += new System.EventHandler(this.ComplaintsListBox_SelectedIndexChanged);
            
            Label statusLabel = new Label() { Text = "Status:", Left = 20, Top = 270, Width = 60 };
            ComboBox statusCB = new ComboBox() { Name = "StatusCB", Left = 90, Top = 270, Width = 150 };
            statusCB.Items.Add("Pending");
            statusCB.Items.Add("In Review");
            statusCB.Items.Add("Resolved");
            statusCB.Items.Add("Rejected");
            
            Label responseLabel = new Label() { Text = "Response:", Left = 20, Top = 310, Width = 70 };
            TextBox responseTB = new TextBox() { Name = "ResponseTB", Left = 90, Top = 310, Width = 330, Height = 60, Multiline = true };
            
            Button updateBtn = new Button() { Name = "UpdateBtn", Text = "Update Status & Response", Left = 90, Top = 380, Width = 200 };
            updateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            
            Button backBtn = new Button() { Name = "BackBtn", Text = "Back", Left = 310, Top = 380, Width = 110 };
            backBtn.Click += new System.EventHandler(this.BackBtn_Click);

            this.Controls.Add(titleLabel);
            this.Controls.Add(complaintsListBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(statusCB);
            this.Controls.Add(responseLabel);
            this.Controls.Add(responseTB);
            this.Controls.Add(updateBtn);
            this.Controls.Add(backBtn);
            
            this.Text = "Complaints Management";
            this.Size = new System.Drawing.Size(480, 470);
            this.ResumeLayout();
        }

        private void AdminComplaintsManagement_Load(object sender, EventArgs e)
        {
            RefreshComplaintsList();
        }

        private void RefreshComplaintsList()
        {
            ListBox complaintsListBox = this.Controls["ComplaintsListBox"] as ListBox;
            complaintsListBox.Items.Clear();

            complaints = DatabaseHelper.GetAllComplaints();
            foreach (Complaint complaint in complaints)
            {
                complaintsListBox.Items.Add($"ID: {complaint.ID} | {complaint.Username} | {complaint.FoodItemName} | Status: {complaint.Status}");
            }
        }

        private void ComplaintsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox complaintsListBox = this.Controls["ComplaintsListBox"] as ListBox;
            ComboBox statusCB = this.Controls["StatusCB"] as ComboBox;
            TextBox responseTB = this.Controls["ResponseTB"] as TextBox;

            if (complaintsListBox.SelectedIndex >= 0 && complaintsListBox.SelectedIndex < complaints.Count)
            {
                Complaint selected = complaints[complaintsListBox.SelectedIndex];
                statusCB.SelectedItem = selected.Status;
                responseTB.Text = selected.AdminResponse;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            ListBox complaintsListBox = this.Controls["ComplaintsListBox"] as ListBox;
            ComboBox statusCB = this.Controls["StatusCB"] as ComboBox;
            TextBox responseTB = this.Controls["ResponseTB"] as TextBox;

            if (complaintsListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a complaint to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Complaint selected = complaints[complaintsListBox.SelectedIndex];
            string newStatus = statusCB.SelectedItem?.ToString() ?? selected.Status;
            string newResponse = responseTB.Text.Trim();

            if (DatabaseHelper.UpdateComplaintStatus(selected.ID, newStatus, newResponse))
            {
                MessageBox.Show("Complaint updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshComplaintsList();
            }
            else
            {
                MessageBox.Show("Failed to update complaint.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            this.Close();
        }
    }
}
