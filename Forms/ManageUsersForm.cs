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
    public partial class ManageUsersForm : Form
    {
        private readonly DatabaseAccess db;

        public ManageUsersForm()
        {
            InitializeComponent();
            db = new DatabaseAccess();
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'quickCart_Shop_ManagementDataSet.Roles' table. You can move, or remove it, as needed.
                this.rolesTableAdapter.Fill(this.quickCart_Shop_ManagementDataSet.Roles);
                // TODO: This line of code loads data into the 'quickCart_Shop_ManagementDataSet.UserLogin' table. You can move, or remove it, as needed.
                this.userLoginTableAdapter.Fill(this.quickCart_Shop_ManagementDataSet.UserLogin);
                // TODO: This line of code loads data into the 'quickCart_Shop_ManagementDataSet.Products' table. You can move, or remove it, as needed.
                this.productsTableAdapter.Fill(this.quickCart_Shop_ManagementDataSet.Products);
                LoadRoles();
                LoadAllUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error " + ex.Message);
            }
        }

        private void LoadRoles()
        {
            try
            {
                DataTable roles = db.ExecuteQuery("SELECT RoleName FROM Roles");
                RolecomboBox.Items.Clear();
                foreach (DataRow row in roles.Rows)
                {
                    RolecomboBox.Items.Add(row["RoleName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load roles: " + ex.Message);
            }
        }

        private void LoadAllUsers()
        {
            try
            {
                string query = @"
                    SELECT 
                        U.UserID, 
                        U.FullName, 
                        U.Username, 
                        U.Password,
                        R.RoleName AS Role,
                        CASE WHEN U.IsActive = 1 THEN 'Active' ELSE 'Inactive' END AS Status,
                        U.CreatedAt
                    FROM Users U
                    JOIN Roles R ON U.RoleID = R.RoleID";

                ManageUserDGV.DataSource = db.ExecuteQuery(query);
                if (ManageUserDGV.Columns.Contains("Password"))
                    ManageUserDGV.Columns["Password"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load users: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            UsernameBox.Text = "";
            PasswordBox.Text = "";
            FullnameBox.Text = "";
            RolecomboBox.SelectedIndex = -1;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = FullnameBox.Text.Trim();
                string username = UsernameBox.Text.Trim();
                string password = PasswordBox.Text.Trim();
                string role = RolecomboBox.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) ||
                    string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("All fields are required.");
                    return;
                }

                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                SqlParameter[] checkParams = {
                    new SqlParameter("@Username", username)
                };

                if (Convert.ToInt32(db.ExecuteScalar(checkQuery, checkParams)) > 0)
                {
                    MessageBox.Show("Username already exists.");
                    return;
                }

                object roleId = db.ExecuteScalar("SELECT RoleID FROM Roles WHERE RoleName = @Role",
                    new SqlParameter[] { new SqlParameter("@Role", role) });

                string insert = @"
                    INSERT INTO Users (Username, Password, FullName, RoleID, IsActive, CreatedAt)
                    VALUES (@Username, @Password, @FullName, @RoleID, 1, GETDATE())";

                SqlParameter[] param = {
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Password", password),
                    new SqlParameter("@FullName", fullName),
                    new SqlParameter("@RoleID", Convert.ToInt32(roleId))
                };

                if (db.ExecuteNonQuery(insert, param) > 0)
                {
                    MessageBox.Show("User added successfully.");
                    LoadAllUsers();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding user: " + ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ManageUserDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Select a user to update.");
                    return;
                }

                int userId = Convert.ToInt32(ManageUserDGV.SelectedRows[0].Cells["UserID"].Value);

                string fullName = FullnameBox.Text.Trim();
                string username = UsernameBox.Text.Trim();
                string password = PasswordBox.Text.Trim();
                string role = RolecomboBox.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) ||
                    string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("All fields are required.");
                    return;
                }

                object roleId = db.ExecuteScalar("SELECT RoleID FROM Roles WHERE RoleName = @Role",
                    new SqlParameter[] { new SqlParameter("@Role", role) });

                string update = @"
                    UPDATE Users
                    SET FullName = @FullName, Username = @Username, Password = @Password, RoleID = @RoleID
                    WHERE UserID = @UserID";

                SqlParameter[] param = {
                    new SqlParameter("@FullName", fullName),
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Password", password),
                    new SqlParameter("@RoleID", Convert.ToInt32(roleId)),
                    new SqlParameter("@UserID", userId)
                };

                if (db.ExecuteNonQuery(update, param) > 0)
                {
                    MessageBox.Show("User updated.");
                    LoadAllUsers();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating user: " + ex.Message);
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ManageUserDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Select a user to delete.");
                    return;
                }

                int userId = Convert.ToInt32(ManageUserDGV.SelectedRows[0].Cells["UserID"].Value);
                string delete = "DELETE FROM Users WHERE UserID = @UserID";
                SqlParameter[] param = { new SqlParameter("@UserID", userId) };

                if (db.ExecuteNonQuery(delete, param) > 0)
                {
                    MessageBox.Show("User removed.");
                    LoadAllUsers();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while removing user: " + ex.Message);
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchUsers();
        }

        private void RolecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchUsers();
        }

        private void SearchUsers()
        {
            try
            {
                string keyword = SearchBox.Text.Trim();
                string selectedRole = RolecomboBox.SelectedItem?.ToString();

                string query = @"
                    SELECT 
                        U.UserID, 
                        U.FullName, 
                        U.Username, 
                        U.Password,
                        R.RoleName AS Role,
                        CASE WHEN U.IsActive = 1 THEN 'Active' ELSE 'Inactive' END AS Status,
                        U.CreatedAt
                    FROM Users U
                    JOIN Roles R ON U.RoleID = R.RoleID
                    WHERE (U.FullName LIKE @Keyword OR U.Username LIKE @Keyword)";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Keyword", "%" + keyword + "%")
                };

                if (!string.IsNullOrEmpty(selectedRole))
                {
                    query += " AND R.RoleName = @RoleName";
                    parameters.Add(new SqlParameter("@RoleName", selectedRole));
                }

                ManageUserDGV.DataSource = db.ExecuteQuery(query, parameters.ToArray());

                if (ManageUserDGV.Columns.Contains("Password"))
                    ManageUserDGV.Columns["Password"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }

        private void AllUsersBtn_Click(object sender, EventArgs e)
        {
            SearchBox.Clear();
            RolecomboBox.SelectedIndex = -1;
            LoadAllUsers();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageUserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.UserID. = this.ManageUserDGV.CurrentRow.Cells[0].Value.ToString();
            //this.UsernameBox.Text = this.ManageUserDGV.CurrentRow.Cells[1].Value.ToString();
            //this.FullnameBox.Text = this.ManageUserDGV.CurrentRow.Cells[2].Value.ToString();
            //  this.PasswordBox.Text = this.ManageUserDGV.CurrentRow.Cells[3].Value.ToString();
            //this.RoleName.Text = this.ManageUserDGV.CurrentRow.Cells[4].Value.ToString();
            //this.dtpDateOfBirth.Text = this.ManageUserDGV.CurrentRow.Cells[5].Value.ToString();
            //this.RoleName.Text = " ";


            var row = ManageUserDGV.Rows[e.RowIndex];
                UsernameBox.Text = row.Cells["Username"].Value.ToString();
                FullnameBox.Text = row.Cells["FullName"].Value.ToString();
                PasswordBox.Text = row.Cells["Password"].Value.ToString();
                //RolecomboBox.SelectedItem = row.Cells["Role"].Value.ToString();
            
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchUsers();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rolesTableAdapter.Fill(this.quickCart_Shop_ManagementDataSet.Roles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }
    }
}
