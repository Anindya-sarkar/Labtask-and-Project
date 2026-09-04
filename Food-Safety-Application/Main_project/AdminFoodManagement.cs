using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Main_project.Models;

namespace Main_project
{
    public partial class AdminFoodManagement : Form
    {
        public AdminFoodManagement()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.AdminFoodManagement_Load);
            this.SuspendLayout();
            
            // Create controls programmatically if not in designer
            Label label1 = new Label() { Text = "Food Name:", Left = 20, Top = 20, Width = 100 };
            TextBox foodNameTB = new TextBox() { Name = "FoodNameTB", Left = 120, Top = 20, Width = 200 };
            
            Label label2 = new Label() { Text = "Category:", Left = 20, Top = 60, Width = 100 };
            TextBox categoryTB = new TextBox() { Name = "CategoryTB", Left = 120, Top = 60, Width = 200 };
            
            Label label3 = new Label() { Text = "Safety Status:", Left = 20, Top = 100, Width = 100 };
            ComboBox safetyStatusCB = new ComboBox() { Name = "SafetyStatusCB", Left = 120, Top = 100, Width = 200 };
            safetyStatusCB.Items.Add("Safe");
            safetyStatusCB.Items.Add("Unsafe");
            safetyStatusCB.Items.Add("Pending");
            
            Button addBtn = new Button() { Name = "AddBtn", Text = "Add Food", Left = 120, Top = 140, Width = 100 };
            addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            
            Button backBtn = new Button() { Name = "BackBtn", Text = "Back", Left = 240, Top = 140, Width = 80 };
            backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            
            ListBox foodsListBox = new ListBox() { Name = "FoodsListBox", Left = 20, Top = 180, Width = 300, Height = 200 };
            
            Button deleteBtn = new Button() { Name = "DeleteBtn", Text = "Delete Selected", Left = 20, Top = 390, Width = 150 };
            deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);

            this.Controls.Add(label1);
            this.Controls.Add(foodNameTB);
            this.Controls.Add(label2);
            this.Controls.Add(categoryTB);
            this.Controls.Add(label3);
            this.Controls.Add(safetyStatusCB);
            this.Controls.Add(addBtn);
            this.Controls.Add(backBtn);
            this.Controls.Add(foodsListBox);
            this.Controls.Add(deleteBtn);
            
            this.Text = "Food Management";
            this.Size = new System.Drawing.Size(400, 500);
            this.ResumeLayout();
        }

        private void AdminFoodManagement_Load(object sender, EventArgs e)
        {
            RefreshFoodsList();
        }

        private void RefreshFoodsList()
        {
            ListBox foodsListBox = this.Controls["FoodsListBox"] as ListBox;
            foodsListBox.Items.Clear();

            List<Food> foods = DatabaseHelper.SearchFoods("");
            foreach (Food food in foods)
            {
                foodsListBox.Items.Add($"{food.FoodName} ({food.Category}) - {food.SafetyStatus}");
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            TextBox foodNameTB = this.Controls["FoodNameTB"] as TextBox;
            TextBox categoryTB = this.Controls["CategoryTB"] as TextBox;
            ComboBox safetyStatusCB = this.Controls["SafetyStatusCB"] as ComboBox;

            string foodName = foodNameTB.Text.Trim();
            string category = categoryTB.Text.Trim();
            string safetyStatus = safetyStatusCB.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(foodName) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(safetyStatus))
            {
                MessageBox.Show("Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DatabaseHelper.AddFood(foodName, category, safetyStatus))
            {
                MessageBox.Show("Food item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foodNameTB.Clear();
                categoryTB.Clear();
                safetyStatusCB.SelectedIndex = -1;
                RefreshFoodsList();
            }
            else
            {
                MessageBox.Show("Failed to add food item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ListBox foodsListBox = this.Controls["FoodsListBox"] as ListBox;

            if (foodsListBox == null || foodsListBox.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select a food item to delete.",
                    "Selection Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string selectedFood = foodsListBox.SelectedItem.ToString();

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete \"" + selectedFood + "\"?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            // DELETE FROM DATABASE HERE
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            this.Close();
        }

        private void AdminFoodManagement_Load_1(object sender, EventArgs e)
        {

        }
    }
}
