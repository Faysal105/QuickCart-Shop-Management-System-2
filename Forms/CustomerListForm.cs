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
    public partial class CustomerListForm : Form
    {
        private readonly DatabaseAccess db;

        public CustomerListForm()
        {
            InitializeComponent();
            db = new DatabaseAccess(); // your helper class for DB
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers(string search = "")
        {
            try
            {
                string query = @"
                    SELECT UserID, Username, FullName, CreatedAt
                    FROM Users
                    WHERE RoleID = (SELECT RoleID FROM Roles WHERE RoleName = 'Customer')
                      AND (Username LIKE @Search OR FullName LIKE @Search)";

                SqlParameter[] param = {
                    new SqlParameter("@Search", "%" + search + "%")
                };

                CustomerListDGV.DataSource = db.ExecuteQuery(query, param);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer list: " + ex.Message);
            }
        }

        private void srcBtn_Click(object sender, EventArgs e)
        {
            LoadCustomers(Seach_box.Text.Trim());
        }

        private void Seach_box_TextChanged(object sender, EventArgs e)
        {
            LoadCustomers(Seach_box.Text.Trim());
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            new SellerDashboard().Show(); // Or AdminDashboard if needed
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