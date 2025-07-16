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
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void BrowseP_Btn_Click(object sender, EventArgs e)
        {
            // Open Browse Products Form
            BrowseProductsForm browseForm = new BrowseProductsForm();
            browseForm.Show();
            this.Hide();
        }

        private void Cart_Btn_Click(object sender, EventArgs e)
        {
            // Open Cart Form
            CartForm cartForm = new CartForm();
            cartForm.Show();
            this.Hide();
        }

        private void MyOrder_Btn_Click(object sender, EventArgs e)
        {
            // Open My Orders Form
            OrderHistoryForm ordersForm = new OrderHistoryForm();
            ordersForm.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Exit the entire application
            Application.Exit();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            // Go back to Login form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}