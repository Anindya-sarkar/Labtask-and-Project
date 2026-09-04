namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            Number = new Label();
            txtCustomerName = new TextBox();
            txtPhoneNumber = new TextBox();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            cmbMembership = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbFoodItem = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtItemPrice = new TextBox();
            btnAddItem = new Button();
            lstOrderedItems = new ListBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            SuspendLayout();

            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(108, 67);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";

            // 
            // Number
            // 
            Number.AutoSize = true;
            Number.Location = new Point(108, 106);
            Number.Name = "Number";
            Number.Size = new Size(41, 15);
            Number.TabIndex = 1;
            Number.Text = "Phone";

            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(206, 67);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(279, 23);
            txtCustomerName.TabIndex = 2;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;

            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(206, 103);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(279, 23);
            txtPhoneNumber.TabIndex = 3;

            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(206, 177);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(51, 19);
            rdoMale.TabIndex = 5;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            rdoMale.CheckedChanged += rdoMale_CheckedChanged;

            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(279, 177);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(63, 19);
            rdoFemale.TabIndex = 6;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;

            // 
            // cmbMembership
            // 
            cmbMembership.FormattingEnabled = true;
            cmbMembership.Items.AddRange(new object[]
            {
                "Regular",
                "Premium",
                "VIP"
            });
            cmbMembership.Location = new Point(206, 218);
            cmbMembership.Name = "cmbMembership";
            cmbMembership.Size = new Size(121, 23);
            cmbMembership.TabIndex = 7;
            cmbMembership.SelectedIndexChanged += cmbMembership_SelectedIndexChanged;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 177);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 8;
            label1.Text = "Gender";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 221);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 9;
            label2.Text = "Membership";

            // 
            // cmbFoodItem
            // 
            cmbFoodItem.FormattingEnabled = true;
            cmbFoodItem.Items.AddRange(new object[]
            {
                "Pizza",
                "Burger",
                "Salad",
                "Drinks"
            });
            cmbFoodItem.Location = new Point(206, 261);
            cmbFoodItem.Name = "cmbFoodItem";
            cmbFoodItem.Size = new Size(121, 23);
            cmbFoodItem.TabIndex = 10;

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 265);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 11;
            label3.Text = "Food Item";

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 265);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 12;
            label4.Text = "Price";

            // 
            // txtItemPrice
            // 
            txtItemPrice.Location = new Point(400, 262);
            txtItemPrice.Name = "txtItemPrice";
            txtItemPrice.Size = new Size(97, 23);
            txtItemPrice.TabIndex = 13;

            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(523, 262);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(61, 23);
            btnAddItem.TabIndex = 14;
            btnAddItem.Text = "Add";
            btnAddItem.UseVisualStyleBackColor = true;

            // 
            // lstOrderedItems
            // 
            lstOrderedItems.FormattingEnabled = true;
            lstOrderedItems.Location = new Point(207, 303);
            lstOrderedItems.Name = "lstOrderedItems";
            lstOrderedItems.Size = new Size(290, 94);
            lstOrderedItems.TabIndex = 15;

            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(207, 416);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(95, 27);
            btnInsert.TabIndex = 16;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;

            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(322, 416);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 27);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;

            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(511, 67);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(95, 27);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;

            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(436, 416);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 27);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 631);

            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(lstOrderedItems);
            Controls.Add(btnAddItem);
            Controls.Add(txtItemPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbFoodItem);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbMembership);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtCustomerName);
            Controls.Add(Number);
            Controls.Add(lblName);

            Name = "Form1";
            Text = "Form1";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label Number;
        private TextBox txtCustomerName;
        private TextBox txtPhoneNumber;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private ComboBox cmbMembership;
        private Label label1;
        private Label label2;
        private ComboBox cmbFoodItem;
        private Label label3;
        private Label label4;
        private TextBox txtItemPrice;
        private Button btnAddItem;
        private ListBox lstOrderedItems;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnSearch;
        private Button btnDelete;
    }
}