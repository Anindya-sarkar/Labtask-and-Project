using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Update connection string based on your local SQL Server instance
        private string connectionString = @"Data Source=DESKTOP-LTVBJJM\SQLEXPRESS01;Integrated Security=True;";
        private Order currentOrder = new Order();

        public Form1()
        {
            InitializeComponent();

            // Wire up event handlers that were missing in Designer
            btnAddItem.Click += btnAddItem_Click;
            btnSearch.Click += btnSearch_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
        }

        // --- Empty Designer Placeholders ---
        private void txtCustomerName_TextChanged(object sender, EventArgs e) { }
        private void rdoMale_CheckedChanged(object sender, EventArgs e) { }
        private void cmbMembership_SelectedIndexChanged(object sender, EventArgs e) { }

        // --- ADD ITEM TO ORDER ---
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string item = cmbFoodItem.SelectedItem?.ToString();
            string priceText = txtItemPrice.Text.Trim();

            if (string.IsNullOrEmpty(item))
            {
                MessageBox.Show("Please select a food item.");
                return;
            }

            string displayItem = string.IsNullOrEmpty(priceText) ? item : $"{item} (${priceText})";

            // Prevents duplicate additions to the order
            if (!currentOrder.AddItem(displayItem))
            {
                MessageBox.Show("This item has already been added to the order.");
                return;
            }

            // Safely retrieve via Indexer
            int lastIndex = currentOrder.Count - 1;
            string itemFromIndexer = currentOrder[lastIndex];
            if (itemFromIndexer != null)
            {
                lstOrderedItems.Items.Add(itemFromIndexer);
            }
        }

        // --- INSERT / REGISTER CUSTOMER ---
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text.Trim();
            string phone = txtPhoneNumber.Text.Trim();
            string gender = rdoMale.Checked ? "Male" : (rdoFemale.Checked ? "Female" : "");
            string membership = cmbMembership.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Customer Name is required.");
                return;
            }

            string itemsCsv = string.Join(",", currentOrder.GetAllItems());

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Customers (CustomerName, Phone, Gender, Membership, OrderedItems, TotalItems) " +
                               "VALUES (@Name, @Phone, @Gender, @Membership, @Items, @Count)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Membership", membership);
                cmd.Parameters.AddWithValue("@Items", itemsCsv);
                cmd.Parameters.AddWithValue("@Count", currentOrder.Count);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer and Order registered successfully!");
                    ClearForm();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601) // Unique constraint violation
                        MessageBox.Show("A customer with this name is already registered.");
                    else
                        MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        // --- SEARCH CUSTOMER ---
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a customer name to search.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Customers WHERE CustomerName = @Name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtPhoneNumber.Text = reader["Phone"].ToString();
                        string gender = reader["Gender"].ToString();
                        rdoMale.Checked = (gender == "Male");
                        rdoFemale.Checked = (gender == "Female");
                        cmbMembership.SelectedItem = reader["Membership"].ToString();

                        // Reset order list and rebuild
                        currentOrder.Clear();
                        lstOrderedItems.Items.Clear();

                        string itemsCsv = reader["OrderedItems"].ToString();
                        if (!string.IsNullOrEmpty(itemsCsv))
                        {
                            string[] itemsArray = itemsCsv.Split(',');
                            foreach (string item in itemsArray)
                            {
                                currentOrder.AddItem(item);
                            }

                            // Populate list box safely using the Order Indexer
                            for (int i = 0; i < currentOrder.Count; i++)
                            {
                                lstOrderedItems.Items.Add(currentOrder[i]);
                            }
                        }

                        MessageBox.Show($"Customer Found!\nTotal Items Ordered: {reader["TotalItems"]}");
                    }
                    else
                    {
                        MessageBox.Show("No customer found with that name.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search Error: " + ex.Message);
                }
            }
        }

        // --- UPDATE CUSTOMER ---
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text.Trim();
            string phone = txtPhoneNumber.Text.Trim();
            string gender = rdoMale.Checked ? "Male" : (rdoFemale.Checked ? "Female" : "");
            string membership = cmbMembership.SelectedItem?.ToString() ?? "";
            string itemsCsv = string.Join(",", currentOrder.GetAllItems());

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Customers SET Phone = @Phone, Gender = @Gender, Membership = @Membership, " +
                               "OrderedItems = @Items, TotalItems = @Count WHERE CustomerName = @Name";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Membership", membership);
                cmd.Parameters.AddWithValue("@Items", itemsCsv);
                cmd.Parameters.AddWithValue("@Count", currentOrder.Count);

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Customer details updated successfully!");
                    else
                        MessageBox.Show("Customer not found.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Error: " + ex.Message);
                }
            }
        }

        // --- DELETE CUSTOMER ---
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a customer name to delete.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Customers WHERE CustomerName = @Name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Customer deleted successfully.");
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Customer not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Error: " + ex.Message);
                }
            }
        }

        private void ClearForm()
        {
            txtCustomerName.Clear();
            txtPhoneNumber.Clear();
            txtItemPrice.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            cmbMembership.SelectedIndex = -1;
            cmbFoodItem.SelectedIndex = -1;
            currentOrder.Clear();
            lstOrderedItems.Items.Clear();
        }
    }

    // --- ORDER CLASS IMPLEMENTATION WITH INDEXER ---
    public class Order
    {
        private List<string> items = new List<string>();

        // Custom Indexer with boundary protection
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < items.Count)
                {
                    return items[index];
                }
                return null; // Prevents program crash on out-of-range index search
            }
            set
            {
                if (index >= 0 && index < items.Count)
                {
                    items[index] = value;
                }
            }
        }

        public int Count => items.Count;

        // Adds unique food item to order
        public bool AddItem(string item)
        {
            if (items.Contains(item))
            {
                return false;
            }
            items.Add(item);
            return true;
        }

        public List<string> GetAllItems() => items;

        public void Clear() => items.Clear();
    }
}
