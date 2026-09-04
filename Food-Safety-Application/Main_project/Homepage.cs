using Main_project.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Main_project
{
    public partial class Homepage : Form
    {

        private Image[] images; 
        private int imageIndex = 0;
      

        public Homepage()
        {
            InitializeComponent();
            {
                this.HPDashboardBt1.Click += new System.EventHandler(this.HPDashboardBt1_Click);
                this.HPageFSafety_RulesBt1.Click += new System.EventHandler(this.HPageFSafety_RulesBt1_Click);
                this.HP_LawsBt.Click += new System.EventHandler(this.HP_LawsBt_Click);
                this.HP_AboutBt.Click += new System.EventHandler(this.HP_AboutBt_Click);
                this.HP_LogInBt1.Click += new System.EventHandler(this.HP_LogInBt1_Click);
                this.Hp_AdminLoginBt1.Click += new System.EventHandler(this.Hp_AdminLoginBt1_Click);
                this.HP_LogoutBt1.Click += new System.EventHandler(this.HP_LogoutBt1_Click);
                //this.button1.Click += new System.EventHandler(this.button1_Click);
                this.HP_usersignin_pnl_signInBt.Click += new System.EventHandler(this.HP_usersignin_pnl_signInBt_Click);
                this.HP_usersignin_pnl_ForgotPassBt.Click += new System.EventHandler(this.HP_usersignin_pnl_ForgotPassBt_Click);
                this.Hp_uSignin_pnl_SignUpBt.Click += new System.EventHandler(this.Hp_uSignin_pnl_SignUpBt_Click);
                this.Hp_usSignin_pnlCLoseBt.Click += new System.EventHandler(this.Hp_usSignin_pnlCLoseBt_Click);
                this.Hp_adminPnlSigninBt.Click += new System.EventHandler(this.Hp_adminPnlSigninBt_Click);
                this.Hp_adminPnlForgotpassBt.Click += new System.EventHandler(this.Hp_adminPnlForgotpassBt_Click);
                this.Hp_AdminpnlCloseBt.Click += new System.EventHandler(this.Hp_AdminpnlCloseBt_Click);
                //this.Imagetimer1.Tick += new System.EventHandler(this.Imagetimer1_Tick);
                this.HPtextbar_timer.Tick += new System.EventHandler(this.HPtextbar_timer_Tick);
                images = new Image[]
    {
        Properties.Resources.FS_HPimage1,
        Properties.Resources.FS_HPimage2,
        Properties.Resources.FS_HPimage3,
        Properties.Resources.FS_HPimage4
    };

                HP_ImageSlideBox.Image = images[0];

                Imagetimer1.Interval = 3000;
                Imagetimer1.Start();
            }
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            pictureBox1.SendToBack(); // Keeps the background image behind all panels
            UserSignInPanel.Visible = false;
            Hp_AdminSIgninPnl.Visible = false;
            panel1.Visible = false;
        }

        private void HPDashboardBt1_Click(object sender, EventArgs e)
        {
            // Toggle side panel menu
            panel1.Visible = !panel1.Visible;
        }

        private void HPageFSafety_RulesBt1_Click(object sender, EventArgs e)
        {
            string rules = "FOOD SAFETY RULES & REGULATIONS\n\n" +
                "1. HYGIENE STANDARDS:\n" +
                "   • Personal hygiene must be maintained\n" +
                "   • Handwashing required before food handling\n" +
                "   • Clean clothing and aprons must be worn\n\n" +
                "2. FOOD STORAGE:\n" +
                "   • Maintain proper temperature (below 4°C for refrigerated)\n" +
                "   • Separate raw and cooked foods\n" +
                "   • Keep all food in sealed containers\n\n" +
                "3. CONTAMINATION PREVENTION:\n" +
                "   • Use separate cutting boards for different food types\n" +
                "   • Sanitize all utensils and surfaces\n" +
                "   • Prevent cross-contamination\n\n" +
                "4. LABELING & TRACEABILITY:\n" +
                "   • All food items must be labeled with date\n" +
                "   • Maintain records of food sources\n" +
                "   • Keep batch numbers for recall purposes\n\n" +
                "5. HEALTH REQUIREMENTS:\n" +
                "   • Employees must have health certificates\n" +
                "   • Report any illness immediately\n" +
                "   • No handling of food when ill\n\n" +
                "6. CLEANING & SANITATION:\n" +
                "   • Daily cleaning schedule required\n" +
                "   • Use approved cleaning agents\n" +
                "   • Maintain pest control measures\n";

            MessageBox.Show(rules, "Food Safety Rules", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HP_LawsBt_Click(object sender, EventArgs e)
        {
            string laws = "FOOD SAFETY LAWS & COMPLIANCE\n\n" +
                "1. LEGAL FRAMEWORKS:\n" +
                "   • Food Safety & Standards Act\n" +
                "   • Hazard Analysis & Critical Control Points (HACCP)\n" +
                "   • Food Adulteration Penalties Act\n\n" +
                "2. PENALTIES FOR VIOLATIONS:\n" +
                "   • First Offense: Warning or fine up to $5000\n" +
                "   • Second Offense: Fine up to $15000 or 6 months imprisonment\n" +
                "   • Serious Violations: Up to 1 year imprisonment + fines\n\n" +
                "3. INSPECTION & LICENSING:\n" +
                "   • Annual health inspections required\n" +
                "   • Food business operator license mandatory\n" +
                "   • Compliance certificate must be displayed\n\n" +
                "4. IMPORT/EXPORT REGULATIONS:\n" +
                "   • All imported food requires certification\n" +
                "   • Quarantine procedures must be followed\n" +
                "   • Customs clearance mandatory\n\n" +
                "5. ALLERGEN DECLARATIONS:\n" +
                "   • All allergens must be clearly labeled\n" +
                "   • Common allergens: peanuts, shellfish, milk, eggs\n" +
                "   • Failure to label is punishable by law\n\n" +
                "6. RECALL PROCEDURES:\n" +
                "   • Immediate notification to health authorities\n" +
                "   • Consumers must be informed within 24 hours\n" +
                "   • Product traceability is mandatory\n";

            MessageBox.Show(laws, "Food Safety Laws", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HP_AboutBt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Food Safety Application — Ensuring food standards and compliance.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HP_LogInBt1_Click(object sender, EventArgs e)
        {
            Hp_AdminSIgninPnl.Visible = false;
            UserSignInPanel.Visible = true;
            UserSignInPanel.BringToFront(); // Forces panel to render above everything else
        }

        private void Hp_AdminLoginBt1_Click(object sender, EventArgs e)
        {
            // Open Admin Sign In panel
            UserSignInPanel.Visible = false;
            Hp_AdminSIgninPnl.Visible = true;
            Hp_AdminSIgninPnl.BringToFront();
        }

        private void HP_LogoutBt1_Click(object sender, EventArgs e)
        {
            SessionManager.Logout();
            UserSignInPanel.Visible = false;
            Hp_AdminSIgninPnl.Visible = false;
            MessageBox.Show("Logged out successfully.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Top Register button action
            MessageBox.Show("Opening Registration Form...", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // App Logo click action
        }

        private void HP_usersignin_pnl_signInBt_Click(object sender, EventArgs e)
        {
            string username = HP_UserSigninUsernameTB.Text.Trim();
            string password = HP_UserSigninPassTB.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Authenticate user with database
            User loggedInUser = DatabaseHelper.AuthenticateUser(username, password);

            if (loggedInUser != null)
            {
                SessionManager.Login(loggedInUser);
                MessageBox.Show($"Welcome, {loggedInUser.FirstName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                User_Page userPage = new User_Page();
                userPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HP_UserSigninPassTB.Clear();
            }
        }

        private void HP_usersignin_pnl_ForgotPassBt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password recovery instructions have been sent.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Hp_uSignin_pnl_SignUpBt_Click(object sender, EventArgs e)
        {
            User_SignUp signUpForm = new User_SignUp();
            signUpForm.Show();
            this.Hide();
        }

        private void Hp_usSignin_pnlCLoseBt_Click(object sender, EventArgs e)
        {
            UserSignInPanel.Visible = false;
        }

        private void Hp_adminPnlSigninBt_Click(object sender, EventArgs e)
        {
            string username = Hp_AdminpnlAdminNameTB.Text.Trim();
            string password = Hp_AdminpnlPassTB.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Admin Name and Password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Authenticate admin (check if role is Admin)
            User adminUser = DatabaseHelper.AuthenticateUser(username, password);

            if (adminUser != null && adminUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                SessionManager.Login(adminUser);
                MessageBox.Show($"Admin '{adminUser.FirstName}' authenticated successfully.", "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdminPage adminPage = new AdminPage();
                adminPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid admin credentials or insufficient permissions.", "Admin Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Hp_AdminpnlPassTB.Clear();
            }
        }

        private void Hp_adminPnlForgotpassBt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin password recovery request sent to administrator email.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Hp_AdminpnlCloseBt_Click(object sender, EventArgs e)
        {
            Hp_AdminSIgninPnl.Visible = false;
        }

        private void Imagetimer1_Tick(object sender, EventArgs e)
        {
            // Slideshow timer logic
            imageIndex = (imageIndex + 1) % 2;
        }

        private void HPtextbar_timer_Tick(object sender, EventArgs e)
        {
            // Horizontal scrolling text ticker animation

            label6.Left -= 2;
            if (label6.Right < 0)
            {
                label6.Left = this.ClientSize.Width;
            }
        }

        private void Imagetimer1_Tick_1(object sender, EventArgs e)
        {
            imageIndex++;

            if (imageIndex >= images.Length)
            {
                imageIndex = 0;
            }

            HP_ImageSlideBox.Image = images[imageIndex];
        }

        private void HP_textbarlabel_Click(object sender, EventArgs e)
        {

        }

        private void HPtextbar_timer_Tick_1(object sender, EventArgs e)
        {

        }
    }
}