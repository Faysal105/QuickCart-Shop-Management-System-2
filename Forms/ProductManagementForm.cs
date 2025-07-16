using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuickCart_Shop_Management.Forms
{
    public partial class ProductManagementForm : Form
    {
        private readonly DatabaseAccess db;

        public ProductManagementForm()
        {
            InitializeComponent();
            db = new DatabaseAccess(); // DB helper class
        }

        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts(string search = "")
        {
            try
            {
                string query = @"
                    SELECT ProductID, Name, Category, Quantity, Price, CreatedBy, CreatedAt
                    FROM Products
                    WHERE Name LIKE @Search OR Category LIKE @Search";

                SqlParameter[] param = {
                    new SqlParameter("@Search", "%" + search + "%")
                };

                ManageProductDGV.DataSource = db.ExecuteQuery(query, param);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load products: " + ex.Message);
            }
        }

        private void srcBtn_Click(object sender, EventArgs e)
        {
            LoadProducts(Seach_box.Text.Trim());
        }

        private void Seach_box_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(Seach_box.Text.Trim());
        }

        private void AllProductsBtn_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = PrNameBox.Text.Trim();
                string category = PrCategoyBox.Text.Trim();
                int quantity = int.Parse(PrQuantityBox.Text.Trim());
                decimal price = decimal.Parse(PrPriceBox.Text.Trim());
                int createdBy = 1; // Replace with actual logged-in user ID

                string query = @"
                    INSERT INTO Products (Name, Category, Quantity, Price, CreatedBy)
                    VALUES (@Name, @Category, @Quantity, @Price, @CreatedBy)";

                SqlParameter[] param = {
                    new SqlParameter("@Name", name),
                    new SqlParameter("@Category", category),
                    new SqlParameter("@Quantity", quantity),
                    new SqlParameter("@Price", price),
                    new SqlParameter("@CreatedBy", createdBy)
                };

                if (db.ExecuteNonQuery(query, param) > 0)
                {
                    MessageBox.Show("Product added successfully.");
                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message);
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ManageProductDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Select a product to delete.");
                    return;
                }

                int productId = Convert.ToInt32(ManageProductDGV.SelectedRows[0].Cells["ProductID"].Value);

                string query = "DELETE FROM Products WHERE ProductID = @ProductID";

                SqlParameter[] param = {
                    new SqlParameter("@ProductID", productId)
                };

                if (db.ExecuteNonQuery(query, param) > 0)
                {
                    MessageBox.Show("Product deleted.");
                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ManageProductDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Select a product to update.");
                    return;
                }

                int productId = Convert.ToInt32(ManageProductDGV.SelectedRows[0].Cells["ProductID"].Value);
                string name = PrNameBox.Text.Trim();
                string category = PrCategoyBox.Text.Trim();
                int quantity = int.Parse(PrQuantityBox.Text.Trim());
                decimal price = decimal.Parse(PrPriceBox.Text.Trim());

                string query = @"
                    UPDATE Products
                    SET Name = @Name, Category = @Category,
                        Quantity = @Quantity, Price = @Price
                    WHERE ProductID = @ProductID";

                SqlParameter[] param = {
                    new SqlParameter("@Name", name),
                    new SqlParameter("@Category", category),
                    new SqlParameter("@Quantity", quantity),
                    new SqlParameter("@Price", price),
                    new SqlParameter("@ProductID", productId)
                };

                if (db.ExecuteNonQuery(query, param) > 0)
                {
                    MessageBox.Show("Product updated.");
                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void ManageProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && ManageProductDGV.Rows[e.RowIndex].Cells["ProductID"].Value != null)
            {
                DataGridViewRow row = ManageProductDGV.Rows[e.RowIndex];

                PrNameBox.Text = row.Cells["Name"].Value.ToString();
                PrCategoyBox.Text = row.Cells["Category"].Value.ToString();
                PrQuantityBox.Text = row.Cells["Quantity"].Value.ToString();
                PrPriceBox.Text = row.Cells["Price"].Value.ToString();
            }
        }

        private void EXTBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }

        private void BackBTn_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Close();
        }
    }
}