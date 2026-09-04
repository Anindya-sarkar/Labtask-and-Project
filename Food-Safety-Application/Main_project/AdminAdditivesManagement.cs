using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Main_project.Models;

namespace Main_project
{
    public partial class AdminAdditivesManagement : Form
    {
        public AdminAdditivesManagement()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.AdminAdditivesManagement_Load);
            this.SuspendLayout();
            
            Label titleLabel = new Label() { Text = "Manage Additives", Left = 20, Top = 20, Width = 300, Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold) };
            
            ListBox additivesListBox = new ListBox() { Name = "AdditivesListBox", Left = 20, Top = 60, Width = 350, Height = 250 };
            
            Label label1 = new Label() { Text = "Additive Name:", Left = 20, Top = 320, Width = 100 };
            TextBox addNameTB = new TextBox() { Name = "AddNameTB", Left = 130, Top = 320, Width = 240 };
            
            Label label2 = new Label() { Text = "INS Number:", Left = 20, Top = 360, Width = 100 };
            TextBox insNumberTB = new TextBox() { Name = "INSNumberTB", Left = 130, Top = 360, Width = 240 };
            
            Label label3 = new Label() { Text = "Max Limit:", Left = 20, Top = 400, Width = 100 };
            TextBox maxLimitTB = new TextBox() { Name = "MaxLimitTB", Left = 130, Top = 400, Width = 240 };
            
            Button backBtn = new Button() { Name = "BackBtn", Text = "Back", Left = 310, Top = 450, Width = 60 };
            backBtn.Click += new System.EventHandler(this.BackBtn_Click);

            this.Controls.Add(titleLabel);
            this.Controls.Add(additivesListBox);
            this.Controls.Add(label1);
            this.Controls.Add(addNameTB);
            this.Controls.Add(label2);
            this.Controls.Add(insNumberTB);
            this.Controls.Add(label3);
            this.Controls.Add(maxLimitTB);
            this.Controls.Add(backBtn);
            
            this.Text = "Additives Management";
            this.Size = new System.Drawing.Size(420, 530);
            this.ResumeLayout();
        }

        private void AdminAdditivesManagement_Load(object sender, EventArgs e)
        {
            ListBox additivesListBox = this.Controls["AdditivesListBox"] as ListBox;
            additivesListBox.Items.Clear();

            List<Additive> additives = DatabaseHelper.GetAllAdditives();
            foreach (Additive additive in additives)
            {
                additivesListBox.Items.Add($"{additive.AdditiveName} (INS: {additive.INSNumber}) - Max: {additive.MaxLimit}");
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            this.Close();
        }

        private void AdminAdditivesManagement_Load_1(object sender, EventArgs e)
        {

        }
    }
}
