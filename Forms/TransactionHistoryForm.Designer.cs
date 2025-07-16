namespace QuickCart_Shop_Management.Forms
{
    partial class TransactionHistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TransactionDGV = new System.Windows.Forms.DataGridView();
            this.transactionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quickCart_Shop_ManagementDataSet5 = new QuickCart_Shop_Management.QuickCart_Shop_ManagementDataSet5();
            this.transactionHistoryTableAdapter = new QuickCart_Shop_Management.QuickCart_Shop_ManagementDataSet5TableAdapters.TransactionHistoryTableAdapter();
            this.srcBtn = new System.Windows.Forms.Button();
            this.EXTBTN = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Seach_box = new System.Windows.Forms.TextBox();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.HomeBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickCart_Shop_ManagementDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionDGV
            // 
            this.TransactionDGV.AutoGenerateColumns = false;
            this.TransactionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIDDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.paidAmountDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn});
            this.TransactionDGV.DataSource = this.transactionHistoryBindingSource;
            this.TransactionDGV.Location = new System.Drawing.Point(12, 207);
            this.TransactionDGV.Name = "TransactionDGV";
            this.TransactionDGV.RowHeadersWidth = 51;
            this.TransactionDGV.RowTemplate.Height = 24;
            this.TransactionDGV.Size = new System.Drawing.Size(669, 186);
            this.TransactionDGV.TabIndex = 0;
            this.TransactionDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionDGV_CellContentClick);
            // 
            // transactionIDDataGridViewTextBoxColumn
            // 
            this.transactionIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.HeaderText = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionIDDataGridViewTextBoxColumn.Name = "transactionIDDataGridViewTextBoxColumn";
            this.transactionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // paidAmountDataGridViewTextBoxColumn
            // 
            this.paidAmountDataGridViewTextBoxColumn.DataPropertyName = "PaidAmount";
            this.paidAmountDataGridViewTextBoxColumn.HeaderText = "PaidAmount";
            this.paidAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paidAmountDataGridViewTextBoxColumn.Name = "paidAmountDataGridViewTextBoxColumn";
            this.paidAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            this.paymentMethodDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionHistoryBindingSource
            // 
            this.transactionHistoryBindingSource.DataMember = "TransactionHistory";
            this.transactionHistoryBindingSource.DataSource = this.quickCart_Shop_ManagementDataSet5;
            // 
            // quickCart_Shop_ManagementDataSet5
            // 
            this.quickCart_Shop_ManagementDataSet5.DataSetName = "QuickCart_Shop_ManagementDataSet5";
            this.quickCart_Shop_ManagementDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionHistoryTableAdapter
            // 
            this.transactionHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // srcBtn
            // 
            this.srcBtn.Location = new System.Drawing.Point(461, 89);
            this.srcBtn.Name = "srcBtn";
            this.srcBtn.Size = new System.Drawing.Size(75, 23);
            this.srcBtn.TabIndex = 49;
            this.srcBtn.Text = "Search";
            this.srcBtn.UseVisualStyleBackColor = true;
            this.srcBtn.Click += new System.EventHandler(this.srcBtn_Click);
            // 
            // EXTBTN
            // 
            this.EXTBTN.Location = new System.Drawing.Point(606, 12);
            this.EXTBTN.Name = "EXTBTN";
            this.EXTBTN.Size = new System.Drawing.Size(75, 23);
            this.EXTBTN.TabIndex = 48;
            this.EXTBTN.Text = "Exit";
            this.EXTBTN.UseVisualStyleBackColor = true;
            this.EXTBTN.Click += new System.EventHandler(this.EXTBTN_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "Search";
            // 
            // Seach_box
            // 
            this.Seach_box.Location = new System.Drawing.Point(209, 89);
            this.Seach_box.Name = "Seach_box";
            this.Seach_box.Size = new System.Drawing.Size(228, 22);
            this.Seach_box.TabIndex = 46;
           //this.Seach_box.TextChanged += new System.EventHandler(this.Seach_box_TextChanged_1);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(580, 399);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(101, 23);
            this.LogoutBtn.TabIndex = 45;
            this.LogoutBtn.Text = "Log Out";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(203, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(262, 32);
            this.label8.TabIndex = 50;
            this.label8.Text = "Transation History";
            // 
            // HomeBTN
            // 
            this.HomeBTN.Location = new System.Drawing.Point(24, 92);
            this.HomeBTN.Name = "HomeBTN";
            this.HomeBTN.Size = new System.Drawing.Size(75, 23);
            this.HomeBTN.TabIndex = 51;
            this.HomeBTN.Text = "Home";
            this.HomeBTN.UseVisualStyleBackColor = true;
            this.HomeBTN.Click += new System.EventHandler(this.HomeBTN_Click);
            // 
            // TransactionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(693, 435);
            this.Controls.Add(this.HomeBTN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.srcBtn);
            this.Controls.Add(this.EXTBTN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Seach_box);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.TransactionDGV);
            this.Name = "TransactionHistoryForm";
            this.Text = "TransactionHistoryForm";
            this.Load += new System.EventHandler(this.TransactionHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickCart_Shop_ManagementDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TransactionDGV;
        private QuickCart_Shop_ManagementDataSet5 quickCart_Shop_ManagementDataSet5;
        private System.Windows.Forms.BindingSource transactionHistoryBindingSource;
        private QuickCart_Shop_ManagementDataSet5TableAdapters.TransactionHistoryTableAdapter transactionHistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button srcBtn;
        private System.Windows.Forms.Button EXTBTN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Seach_box;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button HomeBTN;
    }
}