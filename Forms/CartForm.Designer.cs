namespace QuickCart_Shop_Management.Forms
{
    partial class CartForm
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
            this.CartDGV = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Add_MoreBTn = new System.Windows.Forms.Button();
            this.CkOutbtn = new System.Windows.Forms.Button();
            this.RmvBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Totaltxtbox = new System.Windows.Forms.TextBox();
            this.homeBtn = new System.Windows.Forms.Button();
            this.CartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quickCart_Shop_ManagementDataSet6 = new QuickCart_Shop_Management.QuickCart_Shop_ManagementDataSet6();
            this.quickCartShopManagementDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CartDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickCart_Shop_ManagementDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickCartShopManagementDataSet6BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CartDGV
            // 
            this.CartDGV.AutoGenerateColumns = false;
            this.CartDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CartID,
            this.CustomerID,
            this.ProductID,
            this.Quantity,
            this.AddedAt});
            this.CartDGV.DataSource = this.quickCartShopManagementDataSet6BindingSource;
            this.CartDGV.Location = new System.Drawing.Point(27, 236);
            this.CartDGV.Name = "CartDGV";
            this.CartDGV.RowHeadersWidth = 51;
            this.CartDGV.RowTemplate.Height = 24;
            this.CartDGV.Size = new System.Drawing.Size(756, 150);
            this.CartDGV.TabIndex = 0;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(530, 149);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 33;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Search";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(278, 149);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(228, 22);
            this.SearchBox.TabIndex = 31;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ExitBtn.Location = new System.Drawing.Point(703, 38);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(80, 40);
            this.ExitBtn.TabIndex = 30;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.LogOutBtn.Location = new System.Drawing.Point(703, 406);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(80, 40);
            this.LogOutBtn.TabIndex = 29;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Cart";
            // 
            // Add_MoreBTn
            // 
            this.Add_MoreBTn.Location = new System.Drawing.Point(249, 207);
            this.Add_MoreBTn.Name = "Add_MoreBTn";
            this.Add_MoreBTn.Size = new System.Drawing.Size(75, 23);
            this.Add_MoreBTn.TabIndex = 34;
            this.Add_MoreBTn.Text = "Add";
            this.Add_MoreBTn.UseVisualStyleBackColor = true;
            this.Add_MoreBTn.Click += new System.EventHandler(this.Add_MoreBTn_Click);
            // 
            // CkOutbtn
            // 
            this.CkOutbtn.Location = new System.Drawing.Point(471, 207);
            this.CkOutbtn.Name = "CkOutbtn";
            this.CkOutbtn.Size = new System.Drawing.Size(98, 23);
            this.CkOutbtn.TabIndex = 35;
            this.CkOutbtn.Text = "Check Out";
            this.CkOutbtn.UseVisualStyleBackColor = true;
            this.CkOutbtn.Click += new System.EventHandler(this.CkOutbtn_Click);
            // 
            // RmvBtn
            // 
            this.RmvBtn.Location = new System.Drawing.Point(366, 207);
            this.RmvBtn.Name = "RmvBtn";
            this.RmvBtn.Size = new System.Drawing.Size(75, 23);
            this.RmvBtn.TabIndex = 36;
            this.RmvBtn.Text = "Remove";
            this.RmvBtn.UseVisualStyleBackColor = true;
            this.RmvBtn.Click += new System.EventHandler(this.RmvBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Total";
            // 
            // Totaltxtbox
            // 
            this.Totaltxtbox.Location = new System.Drawing.Point(68, 403);
            this.Totaltxtbox.Name = "Totaltxtbox";
            this.Totaltxtbox.Size = new System.Drawing.Size(119, 22);
            this.Totaltxtbox.TabIndex = 38;
            //this.Totaltxtbox.TextChanged += new System.EventHandler(this.Totaltxtbox_TextChanged);
            // 
            // homeBtn
            // 
            this.homeBtn.Location = new System.Drawing.Point(27, 148);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(75, 23);
            this.homeBtn.TabIndex = 39;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // CartID
            // 
            this.CartID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CartID.HeaderText = "CartID";
            this.CartID.MinimumWidth = 6;
            this.CartID.Name = "CartID";
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // AddedAt
            // 
            this.AddedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AddedAt.HeaderText = "AddedAt";
            this.AddedAt.MinimumWidth = 6;
            this.AddedAt.Name = "AddedAt";
            // 
            // quickCart_Shop_ManagementDataSet6
            // 
            this.quickCart_Shop_ManagementDataSet6.DataSetName = "QuickCart_Shop_ManagementDataSet6";
            this.quickCart_Shop_ManagementDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quickCartShopManagementDataSet6BindingSource
            // 
            this.quickCartShopManagementDataSet6BindingSource.DataSource = this.quickCart_Shop_ManagementDataSet6;
            this.quickCartShopManagementDataSet6BindingSource.Position = 0;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.Totaltxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RmvBtn);
            this.Controls.Add(this.CkOutbtn);
            this.Controls.Add(this.Add_MoreBTn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CartDGV);
            this.Name = "CartForm";
            this.Text = "CartForm";
            ((System.ComponentModel.ISupportInitialize)(this.CartDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickCart_Shop_ManagementDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickCartShopManagementDataSet6BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CartDGV;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add_MoreBTn;
        private System.Windows.Forms.Button CkOutbtn;
        private System.Windows.Forms.Button RmvBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Totaltxtbox;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedAt;
        private System.Windows.Forms.BindingSource quickCartShopManagementDataSet6BindingSource;
        private QuickCart_Shop_ManagementDataSet6 quickCart_Shop_ManagementDataSet6;
    }
}