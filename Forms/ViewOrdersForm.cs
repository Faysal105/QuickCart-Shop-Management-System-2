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
    public partial class ViewOrdersForm : Form
    {
        private readonly DatabaseAccess db;

        public ViewOrdersForm()
        {
            InitializeComponent();
            db = new DatabaseAccess();
        }

        private void ViewOrdersForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders(string search = "")
        {
            try
            {
                string query = @"
                    SELECT 
                        OrderID, 
                        CustomerID, 
                        SellerID, 
                        OrderDate, 
                        TotalAmount, 
                        Status
                    FROM Orders
                    WHERE 
                        CAST(OrderID AS NVARCHAR) LIKE @Search OR
                        CAST(CustomerID AS NVARCHAR) LIKE @Search OR
                        CAST(SellerID AS NVARCHAR) LIKE @Search OR
                        Status LIKE @Search";

                SqlParameter[] param = {
                    new SqlParameter("@Search", "%" + search + "%")
                };

                ViewOrderDGV.DataSource = db.ExecuteQuery(query, param);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private void Seach_box_TextChanged(object sender, EventArgs e)
        {
            LoadOrders(Seach_box.Text.Trim());
        }

        private void srcBtn_Click(object sender, EventArgs e)
        {
            LoadOrders(Seach_box.Text.Trim());
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
            this.Close();
        }

        private void ViewOrderDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: you can show order details here if needed
        }
    }
}
