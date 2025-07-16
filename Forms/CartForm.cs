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
    public partial class CartForm : Form
    {
        private readonly DatabaseAccess db;
        private int currentCustomerID = 1; // <-- Replace with actual logged-in CustomerID

        public CartForm()
        {
            InitializeComponent();
            db = new DatabaseAccess();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            LoadCartItems();
        }

        private void LoadCartItems(string keyword = "")
        {
            try
            {
                string query = @"
            SELECT 
                C.CartID,
                C.CustomerID,
                C.ProductID,
                P.Name,
                C.Quantity,
                P.Price,
                (C.Quantity * P.Price) AS Total,
                C.AddedAt
            FROM Cart C
            JOIN Products P ON C.ProductID = P.ProductID
            WHERE C.CustomerID = @CustomerID
            AND (P.Name LIKE @Keyword OR P.Category LIKE @Keyword)";

                SqlParameter[] parameters = {
            new SqlParameter("@CustomerID", currentCustomerID),
            new SqlParameter("@Keyword", "%" + keyword + "%")
        };

                DataTable dt = db.ExecuteQuery(query, parameters);
                CartDGV.DataSource = dt;

                // ✅ Calculate Total from Cart
                decimal grandTotal = 0;
                foreach (DataRow row in dt.Rows)
                {
                    grandTotal += Convert.ToDecimal(row["Total"]);
                }

                Totaltxtbox.Text = grandTotal.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load cart: " + ex.Message);
            }
        }


        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadCartItems(SearchBox.Text.Trim());
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            LoadCartItems(SearchBox.Text.Trim());
        }

        private void RmvBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CartDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an item to remove.");
                    return;
                }

                int cartId = Convert.ToInt32(CartDGV.SelectedRows[0].Cells["CartID"].Value);

                string query = "DELETE FROM Cart WHERE CartID = @CartID";
                SqlParameter[] param = {
                    new SqlParameter("@CartID", cartId)
                };

                db.ExecuteNonQuery(query, param);
                MessageBox.Show("Item removed from cart.");
                LoadCartItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing item: " + ex.Message);
            }
        }

        private void Add_MoreBTn_Click(object sender, EventArgs e)
        {
            new BrowseProductsForm().Show();
            this.Close();
        }

        private void CkOutbtn_Click(object sender, EventArgs e)
        {
            new PrintInvoiceForm().Show();
            this.Hide();
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

        private void homeBtn_Click(object sender, EventArgs e)
        {
            new CustomerDashboard().Show();
            this.Close();
        }
    }
}