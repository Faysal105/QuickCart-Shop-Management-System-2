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
    public partial class AdminDashboard : Form
    {
        private DatabaseAccess db;

        public AdminDashboard()
        {
            InitializeComponent();
            db = new DatabaseAccess();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            
        }

        

        private void MngU_Btn_Click(object sender, EventArgs e)
        {
            ManageUsersForm manageUsersForm = new ManageUsersForm();
            manageUsersForm.Show();
            this.Hide();
        }

        private void MngP_Btn_Click(object sender, EventArgs e)
        {
            ProductManagementForm productForm = new ProductManagementForm();
            productForm.Show();
            this.Hide();
        }

        private void Transaction_Btn_Click(object sender, EventArgs e)
        {
            TransactionHistoryForm transactionForm = new TransactionHistoryForm();
            transactionForm.Show();
            this.Hide();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                new LoginForm().Show();
                this.Close();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
