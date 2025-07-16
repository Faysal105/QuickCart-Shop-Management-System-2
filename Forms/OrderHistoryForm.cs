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
    public partial class OrderHistoryForm : Form
    {
        private readonly DatabaseAccess db;

        public OrderHistoryForm()
        {
            InitializeComponent();
            db = new DatabaseAccess(); // DB helper
        }

        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders(string search = "")
        {
            try
            {
                string query = @"
                    SELECT OrderID, CustomerID, SellerID, OrderDate, TotalAmount, Status
                    FROM Orders
                    WHERE 
                        CAST(OrderID AS VARCHAR) LIKE @Search
                        OR CAST(CustomerID AS VARCHAR) LIKE @Search
                        OR CAST(SellerID AS VARCHAR) LIKE @Search
                        OR Status LIKE @Search";

                SqlParameter[] param = {
                    new SqlParameter("@Search", "%" + search + "%")
                };

                orderHistoryDGV.DataSource = db.ExecuteQuery(query, param);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order history: " + ex.Message);
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadOrders(SearchBox.Text.Trim());
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            LoadOrders(SearchBox.Text.Trim());
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            new CustomerDashboard().Show(); // or AdminDashboard
            this.Close();
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
    }
}