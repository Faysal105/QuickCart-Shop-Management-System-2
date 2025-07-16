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
    public partial class SellerDashboard : Form
    {
        private readonly int sellerUserID;
        private readonly string sellerName;

        public SellerDashboard(int userId, string name)
        {
            InitializeComponent();
            sellerUserID = userId;
            sellerName = name;
        }

        public SellerDashboard()
        {
            InitializeComponent(); // Only keep if you need default constructor
        }

        private void SellerDashboard_Load(object sender, EventArgs e)
        {
            // Optional: label.Text = $"Welcome, {sellerName}";
        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            UpdateProductForm updateProduct = new UpdateProductForm(sellerUserID, sellerName);
            updateProduct.Show();
            this.Hide(); // Optional
        }

        private void ViewO_Btn_Click(object sender, EventArgs e)
        {
            ViewOrdersForm ordersForm = new ViewOrdersForm(); // If it also needs userId, pass it
            ordersForm.Show();
            this.Hide();
        }

        private void CustomerList_Btn_Click(object sender, EventArgs e)
        {
            CustomerListForm customerListForm = new CustomerListForm();
            customerListForm.Show();
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
            Application.Exit();
        }
    }
}
