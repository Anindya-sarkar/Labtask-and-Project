using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Main_project.Models;

namespace Main_project
{
    public partial class AdminUsersManagement : Form
    {
        public AdminUsersManagement()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.AdminUsersManagement_Load);
            this.SuspendLayout();
            
            Label titleLabel = new Label() { Text = "Manage Users", Left = 20, Top = 20, Width = 300, Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold) };
            
            ListBox usersListBox = new ListBox() { Name = "UsersListBox", Left = 20, Top = 60, Width = 400, Height = 250 };
            
            Label searchLabel = new Label() { Text = "Search Username:", Left = 20, Top = 320, Width = 120 };
            TextBox searchTB = new TextBox() { Name = "SearchTB", Left = 140, Top = 320, Width = 280 };
            
            Button searchBtn = new Button() { Name = "SearchBtn", Text = "Search", Left = 340, Top = 350, Width = 80 };
            searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            
            Button refreshBtn = new Button() { Name = "RefreshBtn", Text = "Refresh", Left = 260, Top = 350, Width = 70 };
            refreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            
            Button backBtn = new Button() { Name = "BackBtn", Text = "Back", Left = 20, Top = 390, Width = 60 };
            backBtn.Click += new System.EventHandler(this.BackBtn_Click);

            this.Controls.Add(titleLabel);
            this.Controls.Add(usersListBox);
            this.Controls.Add(searchLabel);
            this.Controls.Add(searchTB);
            this.Controls.Add(searchBtn);
            this.Controls.Add(refreshBtn);
            this.Controls.Add(backBtn);
            
            this.Text = "Users Management";
            this.Size = new System.Drawing.Size(460, 450);
            this.ResumeLayout();
        }

        private void AdminUsersManagement_Load(object sender, EventArgs e)
        {
            RefreshUsersList();
        }

        private void RefreshUsersList()
        {
            ListBox usersListBox = this.Controls["UsersListBox"] as ListBox;
            usersListBox.Items.Clear();

            List<User> users = DatabaseHelper.GetAllUsers();
            foreach (User user in users)
            {
                usersListBox.Items.Add($"ID: {user.ID} | {user.Username} | {user.FirstName} | Role: {user.Role}");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            TextBox searchTB = this.Controls["SearchTB"] as TextBox;
            string searchTerm = searchTB.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a username to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListBox usersListBox = this.Controls["UsersListBox"] as ListBox;
            usersListBox.Items.Clear();

            List<User> users = DatabaseHelper.GetAllUsers();
            foreach (User user in users)
            {
                if (user.Username.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    usersListBox.Items.Add($"ID: {user.ID} | {user.Username} | {user.FirstName} | Role: {user.Role}");
                }
            }

            if (usersListBox.Items.Count == 0)
            {
                MessageBox.Show("No users found matching that search.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshUsersList();
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            TextBox searchTB = this.Controls["SearchTB"] as TextBox;
            searchTB.Clear();
            RefreshUsersList();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            this.Close();
        }
    }
}
