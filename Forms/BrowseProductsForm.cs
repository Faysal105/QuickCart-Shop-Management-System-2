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
    public partial class BrowseProductsForm : Form
    {
        private readonly DatabaseAccess db;

        public BrowseProductsForm()
        {
            InitializeComponent();
            db = new DatabaseAccess();
        }

        private void BrowseProductsForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            this.BProductDGV.CellClick += BProductDGV_CellClick;
        }

        private void LoadProducts(string search = "")
        {
            try
            {
                string query = @"
                    SELECT ProductID, Name, Category, Quantity, Price
                    FROM Products
                    WHERE Name LIKE @Search OR Category LIKE @Search";

                SqlParameter[] param = {
                    new SqlParameter("@Search", "%" + search + "%")
                };

                BProductDGV.DataSource = db.ExecuteQuery(query, param);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(SearchBox.Text.Trim());
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            LoadProducts(SearchBox.Text.Trim());
        }

        private void BProductDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = BProductDGV.Rows[e.RowIndex];
                ProNameBox.Text = row.Cells["Name"].Value.ToString();
                ProCategoyBox.Text = row.Cells["Category"].Value.ToString();
                ProPriceBox.Text = row.Cells["Price"].Value.ToString();

                int availableQty = Convert.ToInt32(row.Cells["Quantity"].Value);
                QuantityNum.Maximum = availableQty;
                QuantityNum.Value = availableQty > 0 ? 1 : 0;
            }
        }

        private void QuantityNum_ValueChanged(object sender, EventArgs e)
        {
            if (BProductDGV.SelectedRows.Count > 0)
            {
                int selectedQuantity = Convert.ToInt32(QuantityNum.Value);
                int available = Convert.ToInt32(BProductDGV.SelectedRows[0].Cells["Quantity"].Value);

                if (selectedQuantity > available)
                {
                    MessageBox.Show("Quantity exceeds stock available.");
                    QuantityNum.Value = available;
                }
            }
        }

        private void AddToCartBTn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BProductDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Select a product first.");
                    return;
                }

                int productId = Convert.ToInt32(BProductDGV.SelectedRows[0].Cells["ProductID"].Value);
                int stockQuantity = Convert.ToInt32(BProductDGV.SelectedRows[0].Cells["Quantity"].Value);
                int selectedQuantity = Convert.ToInt32(QuantityNum.Value);

                if (selectedQuantity <= 0)
                {
                    MessageBox.Show("Quantity must be at least 1.");
                    return;
                }

                if (selectedQuantity > stockQuantity)
                {
                    MessageBox.Show("Not enough stock available.");
                    return;
                }

                // Insert into Cart
                string insertCart = @"
                    INSERT INTO Cart (ProductID, Quantity)
                    VALUES (@ProductID, @Quantity)";

                SqlParameter[] cartParams = {
                    new SqlParameter("@ProductID", productId),
                    new SqlParameter("@Quantity", selectedQuantity)
                };

                db.ExecuteNonQuery(insertCart, cartParams);

                // Deduct quantity from Products
                string updateProductQty = @"
                    UPDATE Products
                    SET Quantity = Quantity - @DeductQty
                    WHERE ProductID = @ProductID";

                SqlParameter[] updateParams = {
                    new SqlParameter("@DeductQty", selectedQuantity),
                    new SqlParameter("@ProductID", productId)
                };

                db.ExecuteNonQuery(updateProductQty, updateParams);

                MessageBox.Show("Added to cart.");
                LoadProducts(SearchBox.Text.Trim()); // Refresh
                QuantityNum.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding to cart: " + ex.Message);
            }
        }
         private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.Fill(this.quickCart_Shop_ManagementDataSet8.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            new CustomerDashboard().Show();
            this.Close();
        }
    }
}