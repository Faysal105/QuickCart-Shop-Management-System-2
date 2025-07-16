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
    public partial class PrintInvoiceForm : Form
    {
        private readonly DatabaseAccess db;

        public PrintInvoiceForm()
        {
            InitializeComponent();
            db = new DatabaseAccess();
        }

        private void PrintInvoiceForm_Load(object sender, EventArgs e)
        {
            LoadLatestInvoice();
        }

        private void LoadLatestInvoice()
        {
            try
            {
                string query = @"
                    SELECT TOP 1 TotalAmount, PaymentMethod
                    FROM TransactionHistory
                    ORDER BY TransactionDate DESC";

                DataTable dt = db.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    TotaltextBox.Text = dt.Rows[0]["TotalAmount"].ToString();
                    paymentMethodtextBox.Text = dt.Rows[0]["PaymentMethod"].ToString();

                    // Auto check selected method
                    string method = dt.Rows[0]["PaymentMethod"].ToString().ToLower();
                    if (method == "cash")
                        CashBTn.Checked = true;
                    else if (method == "card")
                        cardBtn.Checked = true;
                }
                else
                {
                    TotaltextBox.Text = "0.00";
                    paymentMethodtextBox.Text = "Not Set";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load invoice: " + ex.Message);
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            string selectedMethod = CashBTn.Checked ? "Cash" : (cardBtn.Checked ? "Card" : "");

            if (string.IsNullOrEmpty(selectedMethod))
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            try
            {
                // Simulate invoice saving
                string insert = @"
                    INSERT INTO TransactionHistory (TransactionDate, TotalAmount, PaymentMethod, Username)
                    VALUES (GETDATE(), @Total, @Method, @User)";

                SqlParameter[] param = {
                    new SqlParameter("@Total", TotaltextBox.Text),
                    new SqlParameter("@Method", selectedMethod),
                    new SqlParameter("@User", "DemoUser") // Replace with actual logged in user
                };

                db.ExecuteNonQuery(insert, param);

                MessageBox.Show("Invoice printed/saved successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Print failed: " + ex.Message);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new CartForm().Show(); // Go back to cart
            this.Close();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}