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
    public partial class RegisterForm : Form
    {
        private DatabaseAccess db;

        public RegisterForm()
        {
            InitializeComponent();
            db = new DatabaseAccess();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Optional: Focus username textbox or add hints
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string username = UN_txtBox.Text.Trim();
            string fullName = Name_txtBox.Text.Trim();
            string password = PW_txtBox.Text.Trim();
            string confirmPassword = CPW_txtBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Check if username already exists
            string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            SqlParameter[] checkParams = {
                new SqlParameter("@Username", username)
            };

            object exists = db.ExecuteScalar(checkQuery, checkParams);

            if (Convert.ToInt32(exists) > 0)
            {
                MessageBox.Show("Username already exists. Choose a different one.");
                return;
            }

            // Get RoleID for 'Customer'
            string roleQuery = "SELECT RoleID FROM Roles WHERE RoleName = 'Customer'";
            object roleIdObj = db.ExecuteScalar(roleQuery);

            if (roleIdObj == null)
            {
                MessageBox.Show("Customer role not found in the database.");
                return;
            }

            int roleId = Convert.ToInt32(roleIdObj);

            // Insert user
            string insertQuery = @"INSERT INTO Users (Username, Password, FullName, RoleID, IsActive, CreatedAt)
                                   VALUES (@Username, @Password, @FullName, @RoleID, 1, GETDATE())";

            SqlParameter[] insertParams = {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password),
                new SqlParameter("@FullName", fullName),
                new SqlParameter("@RoleID", roleId)
            };

            int result = db.ExecuteNonQuery(insertQuery, insertParams);

            if (result > 0)
            {
                MessageBox.Show("Registration successful! You can now log in.");
                new LoginForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            UN_txtBox.Text = "";
            Name_txtBox.Text = "";
            PW_txtBox.Text = "";
            CPW_txtBox.Text = "";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Optional empty handlers (if needed)
        private void UN_txtBox_TextChanged(object sender, EventArgs e) { }
        private void Name_txtBox_TextChanged(object sender, EventArgs e) { }
        private void PW_txtBox_TextChanged(object sender, EventArgs e) { }
        private void CPW_txtBox_TextChanged(object sender, EventArgs e) { }
    }
}
