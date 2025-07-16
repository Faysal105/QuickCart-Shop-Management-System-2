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
    public partial class TransactionHistoryForm : Form
    {
        private readonly DatabaseAccess db;

        public TransactionHistoryForm()
        {
            InitializeComponent();
            db = new DatabaseAccess(); // assuming this is your helper class
        }

        private void TransactionHistoryForm_Load(object sender, EventArgs e)
        {
            LoadAllTransactions();
        }

        private void LoadAllTransactions()
        {
            try
            {
                string query = @"
                    SELECT 
                        TransactionID,
                        OrderID,
                        PaymentDate,
                        PaidAmount,
                        PaymentMethod
                    FROM TransactionHistory
                    ORDER BY PaymentDate DESC";

                TransactionDGV.DataSource = db.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load transaction history: " + ex.Message);
            }
        }

        private void FilterTransactions()
        {
            try
            {
                string keyword = Seach_box.Text.Trim();

                string query = @"
                    SELECT 
                        TransactionID,
                        OrderID,
                        PaymentDate,
                        PaidAmount,
                        PaymentMethod
                    FROM TransactionHistory
                    WHERE 
                        OrderID LIKE @Keyword OR 
                        PaymentMethod LIKE @Keyword
                    ORDER BY PaymentDate DESC";

                SqlParameter[] param = {
                    new SqlParameter("@Keyword", "%" + keyword + "%")
                };

                TransactionDGV.DataSource = db.ExecuteQuery(query, param);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }

        private void srcBtn_Click(object sender, EventArgs e)
        {
            FilterTransactions();
        }

        private void Seach_box_TextChanged(object sender, EventArgs e)
        {
            FilterTransactions();
        }

        private void EXTBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show(); // or SellerDashboard if applicable
            this.Close();
        }

        private void TransactionDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: show invoice or details
        }
    }
}