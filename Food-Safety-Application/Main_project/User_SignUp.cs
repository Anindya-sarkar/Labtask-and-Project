using System;
using System.Windows.Forms;
using Main_project.Models;

namespace Main_project
{
    public partial class User_SignUp : Form
    {
        public User_SignUp()
        {
            InitializeComponent();
            {
                // Connects the Click event of 'SignUp_pageCreateAccBT' to the method 'SignUp_pageCreateAccBT_Click'
                this.SignUp_pageCreateAccBT.Click += new System.EventHandler(this.SignUp_pageCreateAccBT_Click);

                // Connects the Click event of 'SignUp_pageClearBT' to the method 'SignUp_pageClearBT_Click'
                this.SignUp_pageClearBT.Click += new System.EventHandler(this.SignUp_pageClearBT_Click);

                // Connects the Click event of 'SignUp_pageCancelBT' to the method 'SignUp_pageCancelBT_Click'
                this.SignUp_pageCancelBT.Click += new System.EventHandler(this.SignUp_pageCancelBT_Click);
            }
        }

        private void User_SignUp_Load(object sender, EventArgs e)
        {
        }

        private void SignUp_pageCreateAccBT_Click(object sender, EventArgs e)
        {
            // Extract values using exact control names
            string firstName = SignUp_page_FistNameTB1.Text.Trim();
            string username = SignUp_page_UserNameTB1.Text.Trim();
            string ageText = SignUp_pageAgeTB1.Text.Trim();
            string email = SignUp_page_EmailTB1.Text.Trim();
            string password = SignUp_page_PasswordTB1.Text;
            string confirmPassword = SignUp_page_ConfirmPasswordTB1.Text;

            // 1. Evaluate gender
            string gender = "";
            if (SingUP_pageRadioButton1.Checked)
            {
                gender = "Male";
            }
            else if (SingUP_pageRadioButton2.Checked)
            {
                gender = "Female";
            }
            else if (SingUP_pageRadioButton3.Checked)
            {
                gender = "Other";
            }

            // 2. Input validation (Checks if gender was selected)
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please fill out all required fields, including gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(ageText, out int age))
            {
                MessageBox.Show("Please enter a valid numeric age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (age < 13 || age > 120)
            {
                MessageBox.Show("Age must be between 13 and 120.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate email format
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create user object and register
            User newUser = new User(0, firstName, username, gender, age, email, password, "User");
            
            if (DatabaseHelper.RegisterUser(newUser))
            {
                MessageBox.Show($"Account successfully created for {firstName}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate to Homepage
                Homepage home = new Homepage();
                home.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed. Username may already exist. Please try again.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignUp_pageClearBT_Click(object sender, EventArgs e)
        {
            // Clear text inputs
            SignUp_page_FistNameTB1.Clear();
            SignUp_page_UserNameTB1.Clear();
            SignUp_pageAgeTB1.Clear();
            SignUp_page_EmailTB1.Clear();
            SignUp_page_PasswordTB1.Clear();
            SignUp_page_ConfirmPasswordTB1.Clear();

            // Reset radio buttons
            SingUP_pageRadioButton1.Checked = false;
            SingUP_pageRadioButton2.Checked = false;
            SingUP_pageRadioButton3.Checked = false;
        }

        private void SignUp_pageCancelBT_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void SignUp_pageGendergroupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}