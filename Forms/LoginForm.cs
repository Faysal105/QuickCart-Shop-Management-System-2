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
    public partial class LoginForm : Form
    {
        private DatabaseAccess db;

        public int userId { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            db = new DatabaseAccess();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Populate Role ComboBox
            RoleCombo.Items.Add("Admin");
            RoleCombo.Items.Add("Seller");
            RoleCombo.Items.Add("Customer");
            RoleCombo.SelectedIndex = 0;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UN_txtBox.Text.Trim();
            string password = PW_txtBox.Text.Trim();
            string role = RoleCombo.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields and select a role.");
                return;
            }

            string query = @"
                SELECT U.UserID, U.FullName, R.RoleName, U.IsActive
                FROM Users U
                JOIN Roles R ON U.RoleID = R.RoleID
                WHERE U.Username = @Username AND U.Password = @Password AND R.RoleName = @Role";

            SqlParameter[] parameters = {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password),
                new SqlParameter("@Role", role)
            };

            DataTable dt = db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                bool isActive = Convert.ToBoolean(dt.Rows[0]["IsActive"]);
                string fullName = dt.Rows[0]["FullName"].ToString();

                if (!isActive)
                {
                    MessageBox.Show("This account is inactive. Please contact the administrator.");
                    return;
                }

                MessageBox.Show($"Welcome, {fullName}!");

                // Redirect to role-based dashboard
                switch (role)
                {
                    case "Admin":
                        new AdminDashboard().Show();
                        break;
                    case "Seller":
                        new SellerDashboard(userId,Name).Show();
                        break;
                    case "Customer":
                        new CustomerDashboard().Show();
                        break;
                    default:
                        MessageBox.Show("Invalid role.");
                        break;
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed. Check your credentials and role.");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            UN_txtBox.Text = "";
            PW_txtBox.Text = "";
            RoleCombo.SelectedIndex = 0;
        }

        private void RoleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: add logic if needed when role changes
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string selectedRole = RoleCombo.SelectedItem?.ToString();

            if (selectedRole != "Customer")
            {
                MessageBox.Show("Only customers are allowed to register.\nPlease select 'Customer' from the role dropdown.");
                return;
            }

            // Proceed to show the registration form for customers
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide(); // optional: hide login form while registration is open
        }


        private void UN_txtBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: live validation
        }

        private void PW_txtBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: live validation
        }
    }
}
