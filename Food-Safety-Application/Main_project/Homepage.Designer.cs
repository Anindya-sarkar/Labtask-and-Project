using System.Windows.Forms;

namespace Main_project
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Hp_AdminSIgninPnl_Paint(object sender, PaintEventArgs e)
        {
            
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.FoodSafetyAppLabel = new System.Windows.Forms.Label();
            this.HPDashboardBt1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HP_LogoutBt1 = new System.Windows.Forms.Button();
            this.HP_AboutBt = new System.Windows.Forms.Button();
            this.Hp_AdminLoginBt1 = new System.Windows.Forms.Button();
            this.HP_LogInBt1 = new System.Windows.Forms.Button();
            this.HP_LawsBt = new System.Windows.Forms.Button();
            this.HPageFSafety_RulesBt1 = new System.Windows.Forms.Button();
            this.HP_ImageSlideBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Imagetimer1 = new System.Windows.Forms.Timer(this.components);
            this.HPtextbar_timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HP_UserSigninUsernameTB = new System.Windows.Forms.TextBox();
            this.HP_UserSigninPassTB = new System.Windows.Forms.TextBox();
            this.HP_usersignin_pnl_signInBt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Hp_uSignin_pnl_SignUpBt = new System.Windows.Forms.Button();
            this.HP_usersignin_pnl_ForgotPassBt = new System.Windows.Forms.Button();
            this.Hp_usSignin_pnlCLoseBt = new System.Windows.Forms.Button();
            this.UserSignInPanel = new System.Windows.Forms.Panel();
            this.Hp_AdminSIgninPnl = new System.Windows.Forms.Panel();
            this.Hp_AdminpnlCloseBt = new System.Windows.Forms.Button();
            this.Hp_adminPnlForgotpassBt = new System.Windows.Forms.Button();
            this.Hp_adminPnlSigninBt = new System.Windows.Forms.Button();
            this.Hp_AdminpnlPassTB = new System.Windows.Forms.TextBox();
            this.Hp_AdminpnlAdminNameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HP_ImageSlideBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.UserSignInPanel.SuspendLayout();
            this.Hp_AdminSIgninPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // FoodSafetyAppLabel
            // 
            this.FoodSafetyAppLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FoodSafetyAppLabel.AutoSize = true;
            this.FoodSafetyAppLabel.BackColor = System.Drawing.Color.Yellow;
            this.FoodSafetyAppLabel.Font = new System.Drawing.Font("Showcard Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodSafetyAppLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FoodSafetyAppLabel.Location = new System.Drawing.Point(229, 31);
            this.FoodSafetyAppLabel.Name = "FoodSafetyAppLabel";
            this.FoodSafetyAppLabel.Size = new System.Drawing.Size(200, 26);
            this.FoodSafetyAppLabel.TabIndex = 1;
            this.FoodSafetyAppLabel.Text = "Food Safety APP";
            this.FoodSafetyAppLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HPDashboardBt1
            // 
            this.HPDashboardBt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HPDashboardBt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HPDashboardBt1.Location = new System.Drawing.Point(12, 79);
            this.HPDashboardBt1.Name = "HPDashboardBt1";
            this.HPDashboardBt1.Size = new System.Drawing.Size(101, 28);
            this.HPDashboardBt1.TabIndex = 2;
            this.HPDashboardBt1.Text = "Dashboard";
            this.HPDashboardBt1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.HP_LogoutBt1);
            this.panel1.Controls.Add(this.HP_AboutBt);
            this.panel1.Controls.Add(this.Hp_AdminLoginBt1);
            this.panel1.Controls.Add(this.HP_LogInBt1);
            this.panel1.Controls.Add(this.HP_LawsBt);
            this.panel1.Controls.Add(this.HPageFSafety_RulesBt1);
            this.panel1.Location = new System.Drawing.Point(12, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 219);
            this.panel1.TabIndex = 3;
            // 
            // HP_LogoutBt1
            // 
            this.HP_LogoutBt1.BackColor = System.Drawing.Color.Red;
            this.HP_LogoutBt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HP_LogoutBt1.Location = new System.Drawing.Point(16, 179);
            this.HP_LogoutBt1.Name = "HP_LogoutBt1";
            this.HP_LogoutBt1.Size = new System.Drawing.Size(115, 29);
            this.HP_LogoutBt1.TabIndex = 6;
            this.HP_LogoutBt1.Text = "Log out";
            this.HP_LogoutBt1.UseVisualStyleBackColor = false;
            // 
            // HP_AboutBt
            // 
            this.HP_AboutBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.HP_AboutBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HP_AboutBt.Location = new System.Drawing.Point(16, 78);
            this.HP_AboutBt.Name = "HP_AboutBt";
            this.HP_AboutBt.Size = new System.Drawing.Size(129, 31);
            this.HP_AboutBt.TabIndex = 5;
            this.HP_AboutBt.Text = "About";
            this.HP_AboutBt.UseVisualStyleBackColor = false;
            // 
            // Hp_AdminLoginBt1
            // 
            this.Hp_AdminLoginBt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Hp_AdminLoginBt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hp_AdminLoginBt1.Location = new System.Drawing.Point(16, 147);
            this.Hp_AdminLoginBt1.Name = "Hp_AdminLoginBt1";
            this.Hp_AdminLoginBt1.Size = new System.Drawing.Size(129, 26);
            this.Hp_AdminLoginBt1.TabIndex = 4;
            this.Hp_AdminLoginBt1.Text = "Admin Login";
            this.Hp_AdminLoginBt1.UseVisualStyleBackColor = false;
            // 
            // HP_LogInBt1
            // 
            this.HP_LogInBt1.BackColor = System.Drawing.Color.Lime;
            this.HP_LogInBt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HP_LogInBt1.Location = new System.Drawing.Point(16, 114);
            this.HP_LogInBt1.Name = "HP_LogInBt1";
            this.HP_LogInBt1.Size = new System.Drawing.Size(129, 27);
            this.HP_LogInBt1.TabIndex = 3;
            this.HP_LogInBt1.Text = "User Login";
            this.HP_LogInBt1.UseVisualStyleBackColor = false;
            // 
            // HP_LawsBt
            // 
            this.HP_LawsBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.HP_LawsBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HP_LawsBt.Location = new System.Drawing.Point(16, 47);
            this.HP_LawsBt.Name = "HP_LawsBt";
            this.HP_LawsBt.Size = new System.Drawing.Size(129, 25);
            this.HP_LawsBt.TabIndex = 1;
            this.HP_LawsBt.Text = "Laws";
            this.HP_LawsBt.UseVisualStyleBackColor = false;
            // 
            // HPageFSafety_RulesBt1
            // 
            this.HPageFSafety_RulesBt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.HPageFSafety_RulesBt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HPageFSafety_RulesBt1.Location = new System.Drawing.Point(16, 18);
            this.HPageFSafety_RulesBt1.Name = "HPageFSafety_RulesBt1";
            this.HPageFSafety_RulesBt1.Size = new System.Drawing.Size(129, 28);
            this.HPageFSafety_RulesBt1.TabIndex = 0;
            this.HPageFSafety_RulesBt1.Text = "Food Safety Rules";
            this.HPageFSafety_RulesBt1.UseVisualStyleBackColor = false;
            // 
            // HP_ImageSlideBox
            // 
            this.HP_ImageSlideBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HP_ImageSlideBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.HP_ImageSlideBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("HP_ImageSlideBox.ErrorImage")));
            this.HP_ImageSlideBox.Image = global::Main_project.Properties.Resources.FS_HPimage4;
            this.HP_ImageSlideBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("HP_ImageSlideBox.InitialImage")));
            this.HP_ImageSlideBox.Location = new System.Drawing.Point(199, 96);
            this.HP_ImageSlideBox.Name = "HP_ImageSlideBox";
            this.HP_ImageSlideBox.Size = new System.Drawing.Size(373, 184);
            this.HP_ImageSlideBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HP_ImageSlideBox.TabIndex = 4;
            this.HP_ImageSlideBox.TabStop = false;
            this.HP_ImageSlideBox.UseWaitCursor = true;
            this.HP_ImageSlideBox.WaitOnLoad = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Imagetimer1
            // 
            this.Imagetimer1.Enabled = true;
            this.Imagetimer1.Interval = 3000;
            this.Imagetimer1.Tick += new System.EventHandler(this.Imagetimer1_Tick_1);
            // 
            // HPtextbar_timer
            // 
            this.HPtextbar_timer.Enabled = true;
            this.HPtextbar_timer.Interval = 30;
            this.HPtextbar_timer.Tick += new System.EventHandler(this.HPtextbar_timer_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(45, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // HP_UserSigninUsernameTB
            // 
            this.HP_UserSigninUsernameTB.Location = new System.Drawing.Point(118, 30);
            this.HP_UserSigninUsernameTB.Margin = new System.Windows.Forms.Padding(2);
            this.HP_UserSigninUsernameTB.Name = "HP_UserSigninUsernameTB";
            this.HP_UserSigninUsernameTB.Size = new System.Drawing.Size(174, 20);
            this.HP_UserSigninUsernameTB.TabIndex = 2;
            // 
            // HP_UserSigninPassTB
            // 
            this.HP_UserSigninPassTB.Location = new System.Drawing.Point(118, 58);
            this.HP_UserSigninPassTB.Margin = new System.Windows.Forms.Padding(2);
            this.HP_UserSigninPassTB.Name = "HP_UserSigninPassTB";
            this.HP_UserSigninPassTB.Size = new System.Drawing.Size(174, 20);
            this.HP_UserSigninPassTB.TabIndex = 3;
            // 
            // HP_usersignin_pnl_signInBt
            // 
            this.HP_usersignin_pnl_signInBt.BackColor = System.Drawing.Color.Lime;
            this.HP_usersignin_pnl_signInBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.HP_usersignin_pnl_signInBt.Location = new System.Drawing.Point(169, 93);
            this.HP_usersignin_pnl_signInBt.Margin = new System.Windows.Forms.Padding(2);
            this.HP_usersignin_pnl_signInBt.Name = "HP_usersignin_pnl_signInBt";
            this.HP_usersignin_pnl_signInBt.Size = new System.Drawing.Size(92, 24);
            this.HP_usersignin_pnl_signInBt.TabIndex = 4;
            this.HP_usersignin_pnl_signInBt.Text = "Sign In";
            this.HP_usersignin_pnl_signInBt.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Don\'t  Have Account . ";
            // 
            // Hp_uSignin_pnl_SignUpBt
            // 
            this.Hp_uSignin_pnl_SignUpBt.BackColor = System.Drawing.Color.Khaki;
            this.Hp_uSignin_pnl_SignUpBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hp_uSignin_pnl_SignUpBt.Location = new System.Drawing.Point(161, 137);
            this.Hp_uSignin_pnl_SignUpBt.Margin = new System.Windows.Forms.Padding(2);
            this.Hp_uSignin_pnl_SignUpBt.Name = "Hp_uSignin_pnl_SignUpBt";
            this.Hp_uSignin_pnl_SignUpBt.Size = new System.Drawing.Size(56, 19);
            this.Hp_uSignin_pnl_SignUpBt.TabIndex = 6;
            this.Hp_uSignin_pnl_SignUpBt.Text = "Sign UP";
            this.Hp_uSignin_pnl_SignUpBt.UseVisualStyleBackColor = false;
            this.Hp_uSignin_pnl_SignUpBt.Click += new System.EventHandler(this.Hp_uSignin_pnl_SignUpBt_Click);
            // 
            // HP_usersignin_pnl_ForgotPassBt
            // 
            this.HP_usersignin_pnl_ForgotPassBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HP_usersignin_pnl_ForgotPassBt.Location = new System.Drawing.Point(59, 97);
            this.HP_usersignin_pnl_ForgotPassBt.Margin = new System.Windows.Forms.Padding(2);
            this.HP_usersignin_pnl_ForgotPassBt.Name = "HP_usersignin_pnl_ForgotPassBt";
            this.HP_usersignin_pnl_ForgotPassBt.Size = new System.Drawing.Size(105, 20);
            this.HP_usersignin_pnl_ForgotPassBt.TabIndex = 7;
            this.HP_usersignin_pnl_ForgotPassBt.Text = "Forgot Password";
            this.HP_usersignin_pnl_ForgotPassBt.UseVisualStyleBackColor = false;
            // 
            // Hp_usSignin_pnlCLoseBt
            // 
            this.Hp_usSignin_pnlCLoseBt.BackColor = System.Drawing.Color.OrangeRed;
            this.Hp_usSignin_pnlCLoseBt.Location = new System.Drawing.Point(284, 5);
            this.Hp_usSignin_pnlCLoseBt.Margin = new System.Windows.Forms.Padding(2);
            this.Hp_usSignin_pnlCLoseBt.Name = "Hp_usSignin_pnlCLoseBt";
            this.Hp_usSignin_pnlCLoseBt.Size = new System.Drawing.Size(34, 17);
            this.Hp_usSignin_pnlCLoseBt.TabIndex = 8;
            this.Hp_usSignin_pnlCLoseBt.Text = "X";
            this.Hp_usSignin_pnlCLoseBt.UseVisualStyleBackColor = false;
            // 
            // UserSignInPanel
            // 
            this.UserSignInPanel.BackColor = System.Drawing.Color.Khaki;
            this.UserSignInPanel.Controls.Add(this.Hp_usSignin_pnlCLoseBt);
            this.UserSignInPanel.Controls.Add(this.HP_usersignin_pnl_ForgotPassBt);
            this.UserSignInPanel.Controls.Add(this.Hp_uSignin_pnl_SignUpBt);
            this.UserSignInPanel.Controls.Add(this.label3);
            this.UserSignInPanel.Controls.Add(this.HP_usersignin_pnl_signInBt);
            this.UserSignInPanel.Controls.Add(this.HP_UserSigninPassTB);
            this.UserSignInPanel.Controls.Add(this.HP_UserSigninUsernameTB);
            this.UserSignInPanel.Controls.Add(this.label2);
            this.UserSignInPanel.Controls.Add(this.label1);
            this.UserSignInPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.UserSignInPanel.Location = new System.Drawing.Point(273, 0);
            this.UserSignInPanel.Margin = new System.Windows.Forms.Padding(2);
            this.UserSignInPanel.Name = "UserSignInPanel";
            this.UserSignInPanel.Size = new System.Drawing.Size(327, 366);
            this.UserSignInPanel.TabIndex = 9;
            // 
            // Hp_AdminSIgninPnl
            // 
            this.Hp_AdminSIgninPnl.Controls.Add(this.Hp_AdminpnlCloseBt);
            this.Hp_AdminSIgninPnl.Controls.Add(this.Hp_adminPnlForgotpassBt);
            this.Hp_AdminSIgninPnl.Controls.Add(this.Hp_adminPnlSigninBt);
            this.Hp_AdminSIgninPnl.Controls.Add(this.Hp_AdminpnlPassTB);
            this.Hp_AdminSIgninPnl.Controls.Add(this.Hp_AdminpnlAdminNameTB);
            this.Hp_AdminSIgninPnl.Controls.Add(this.label5);
            this.Hp_AdminSIgninPnl.Controls.Add(this.label4);
            this.Hp_AdminSIgninPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.Hp_AdminSIgninPnl.Location = new System.Drawing.Point(-54, 0);
            this.Hp_AdminSIgninPnl.Margin = new System.Windows.Forms.Padding(2);
            this.Hp_AdminSIgninPnl.Name = "Hp_AdminSIgninPnl";
            this.Hp_AdminSIgninPnl.Size = new System.Drawing.Size(327, 366);
            this.Hp_AdminSIgninPnl.TabIndex = 10;
            this.Hp_AdminSIgninPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.Hp_AdminSIgninPnl_Paint);
            // 
            // Hp_AdminpnlCloseBt
            // 
            this.Hp_AdminpnlCloseBt.BackColor = System.Drawing.Color.OrangeRed;
            this.Hp_AdminpnlCloseBt.Location = new System.Drawing.Point(285, 6);
            this.Hp_AdminpnlCloseBt.Margin = new System.Windows.Forms.Padding(2);
            this.Hp_AdminpnlCloseBt.Name = "Hp_AdminpnlCloseBt";
            this.Hp_AdminpnlCloseBt.Size = new System.Drawing.Size(33, 23);
            this.Hp_AdminpnlCloseBt.TabIndex = 6;
            this.Hp_AdminpnlCloseBt.Text = "X";
            this.Hp_AdminpnlCloseBt.UseVisualStyleBackColor = false;
            // 
            // Hp_adminPnlForgotpassBt
            // 
            this.Hp_adminPnlForgotpassBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Hp_adminPnlForgotpassBt.Location = new System.Drawing.Point(47, 115);
            this.Hp_adminPnlForgotpassBt.Margin = new System.Windows.Forms.Padding(2);
            this.Hp_adminPnlForgotpassBt.Name = "Hp_adminPnlForgotpassBt";
            this.Hp_adminPnlForgotpassBt.Size = new System.Drawing.Size(104, 24);
            this.Hp_adminPnlForgotpassBt.TabIndex = 5;
            this.Hp_adminPnlForgotpassBt.Text = "Forgot Password";
            this.Hp_adminPnlForgotpassBt.UseVisualStyleBackColor = false;
            // 
            // Hp_adminPnlSigninBt
            // 
            this.Hp_adminPnlSigninBt.BackColor = System.Drawing.Color.Lime;
            this.Hp_adminPnlSigninBt.Location = new System.Drawing.Point(181, 114);
            this.Hp_adminPnlSigninBt.Margin = new System.Windows.Forms.Padding(2);
            this.Hp_adminPnlSigninBt.Name = "Hp_adminPnlSigninBt";
            this.Hp_adminPnlSigninBt.Size = new System.Drawing.Size(98, 24);
            this.Hp_adminPnlSigninBt.TabIndex = 4;
            this.Hp_adminPnlSigninBt.Text = "SIGN IN";
            this.Hp_adminPnlSigninBt.UseVisualStyleBackColor = false;
            // 
            // Hp_AdminpnlPassTB
            // 
            this.Hp_AdminpnlPassTB.Location = new System.Drawing.Point(129, 76);
            this.Hp_AdminpnlPassTB.Margin = new System.Windows.Forms.Padding(2);
            this.Hp_AdminpnlPassTB.Name = "Hp_AdminpnlPassTB";
            this.Hp_AdminpnlPassTB.Size = new System.Drawing.Size(151, 20);
            this.Hp_AdminpnlPassTB.TabIndex = 3;
            // 
            // Hp_AdminpnlAdminNameTB
            // 
            this.Hp_AdminpnlAdminNameTB.Location = new System.Drawing.Point(129, 42);
            this.Hp_AdminpnlAdminNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.Hp_AdminpnlAdminNameTB.Name = "Hp_AdminpnlAdminNameTB";
            this.Hp_AdminpnlAdminNameTB.Size = new System.Drawing.Size(151, 20);
            this.Hp_AdminpnlAdminNameTB.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Wheat;
            this.label5.Location = new System.Drawing.Point(45, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Wheat;
            this.label4.Location = new System.Drawing.Point(45, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Admin Name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(0, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "WELCOME TO FOOD SAFETY APPS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HP_ImageSlideBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HPDashboardBt1);
            this.Controls.Add(this.FoodSafetyAppLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Hp_AdminSIgninPnl);
            this.Controls.Add(this.UserSignInPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HP_ImageSlideBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.UserSignInPanel.ResumeLayout(false);
            this.UserSignInPanel.PerformLayout();
            this.Hp_AdminSIgninPnl.ResumeLayout(false);
            this.Hp_AdminSIgninPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FoodSafetyAppLabel;
        private System.Windows.Forms.Button HPDashboardBt1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HP_LogoutBt1;
        private System.Windows.Forms.Button HP_AboutBt;
        private System.Windows.Forms.Button Hp_AdminLoginBt1;
        private System.Windows.Forms.Button HP_LogInBt1;
        private System.Windows.Forms.Button HP_LawsBt;
        private System.Windows.Forms.Button HPageFSafety_RulesBt1;
        private System.Windows.Forms.PictureBox HP_ImageSlideBox;
        private System.Windows.Forms.Timer Imagetimer1;
        private System.Windows.Forms.Timer HPtextbar_timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HP_UserSigninPassTB;
        private System.Windows.Forms.TextBox HP_UserSigninUsernameTB;
        private System.Windows.Forms.Button Hp_uSignin_pnl_SignUpBt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button HP_usersignin_pnl_signInBt;
        private System.Windows.Forms.Button HP_usersignin_pnl_ForgotPassBt;
        private System.Windows.Forms.Button Hp_usSignin_pnlCLoseBt;
        private System.Windows.Forms.Panel UserSignInPanel;
        private System.Windows.Forms.Panel Hp_AdminSIgninPnl;
        private System.Windows.Forms.Button Hp_adminPnlForgotpassBt;
        private System.Windows.Forms.Button Hp_adminPnlSigninBt;
        private System.Windows.Forms.TextBox Hp_AdminpnlPassTB;
        private System.Windows.Forms.TextBox Hp_AdminpnlAdminNameTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Hp_AdminpnlCloseBt;
        private Label label6;
    }
}

