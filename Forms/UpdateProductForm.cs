using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuickCart_Shop_Management.Forms
{
    public partial class UpdateProductForm : Form
    {
        private readonly DatabaseAccess db;
        private readonly int sellerUserID;
        private readonly string sellerName;

        public UpdateProductForm(int userId, string name)
        {
            InitializeComponent();
            db = new DatabaseAccess();
            sellerUserID = userId;
            sellerName = name;
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
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
                    WHERE (Name LIKE @Search OR Category LIKE @Search)
                      AND CreatedBy = @SellerID";

                SqlParameter[] param = {
                    new SqlParameter("@Search", "%" + search + "%"),
                    new SqlParameter("@SellerID", sellerUserID)
                };

                ProductDGV.DataSource = db.ExecuteQuery(query, param);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void Seach_box_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(Seach_box.Text.Trim());
        }

        private void srcBtn_Click(object sender, EventArgs e)
        {
            LoadProducts(Seach_box.Text.Trim());
        }

        private void AllpBtn_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Select a row to update.");
                    return;
                }

                DataGridViewRow row = ProductDGV.SelectedRows[0];

                int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                string name = row.Cells["Name"].Value?.ToString();
                string category = row.Cells["Category"].Value?.ToString();
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                string query = @"
                    UPDATE Products
                    SET Name = @Name,
                        Category = @Category,
                        Quantity = @Quantity,
                        Price = @Price
                    WHERE ProductID = @ProductID AND CreatedBy = @SellerID";

                SqlParameter[] param = {
                    new SqlParameter("@Name", name),
                    new SqlParameter("@Category", category),
                    new SqlParameter("@Quantity", quantity),
                    new SqlParameter("@Price", price),
                    new SqlParameter("@ProductID", productId),
                    new SqlParameter("@SellerID", sellerUserID)
                };

                int result = db.ExecuteNonQuery(query, param);

                if (result > 0)
                {
                    MessageBox.Show("Product updated successfully.");
                    LoadProducts(Seach_box.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving: " + ex.Message);
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            SellerDashboard sellerDashboard = new SellerDashboard();
            sellerDashboard.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && ProductDGV.Rows[e.RowIndex].Cells["ProductID"].Value != null)
            {
                DataGridViewRow row = ProductDGV.Rows[e.RowIndex];
                UpPrQuantityBox.Text = row.Cells["Quantity"].Value.ToString();
                UpPrPriceBox.Text = row.Cells["Price"].Value.ToString();
            }
        }

        private void UpPrPriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpPrQuantityBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
