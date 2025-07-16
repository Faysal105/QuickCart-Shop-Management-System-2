namespace QuickCart_Shop_Management.Forms
{
    partial class ProductManagementForm
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
            this.AllProductsBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.usersTableAdapter = new QuickCart_Shop_Management.QuickCart_Shop_ManagementDataSetTableAdapters.UsersTableAdapter();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.quickCart_Shop_ManagementDataSet = new QuickCart_Shop_Management.QuickCart_Shop_ManagementDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ManageProductDGV = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quickCart_Shop_ManagementDataSet1 = new QuickCart_Shop_Management.QuickCart_Shop_ManagementDataSet1();
            this.productsTableAdapter = new QuickCart_Shop_Management.QuickCart_Shop_ManagementDataSet1TableAdapters.ProductsTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.EXTBTN = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Seach_box = new System.Windows.Forms.TextBox();
            this.PrNameBox = new System.Windows.Forms.TextBox();
            this.PrCategoyBox = new System.Windows.Forms.TextBox();
            this.PrQuantityBox = new System.Windows.Forms.TextBox();
            this.PrPriceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.srcBtn = new System.Windows.Forms.Button();
            this.BackBTn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quickCart_Shop_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageProductDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickCart_Shop_ManagementDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // AllProductsBtn
            // 
            this.AllProductsBtn.Location = new System.Drawing.Point(717, 280);
            this.AllProductsBtn.Name = "AllProductsBtn";
            this.AllProductsBtn.Size = new System.Drawing.Size(124, 23);
            this.AllProductsBtn.TabIndex = 34;
            this.AllProductsBtn.Text = "All Products";
            this.AllProductsBtn.UseVisualStyleBackColor = true;
            this.AllProductsBtn.Click += new System.EventHandler(this.AllProductsBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, -82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 32);
            this.label4.TabIndex = 33;
            this.label4.Text = "Manage Users";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(456, -29);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 32;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(792, 546);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(101, 23);
            this.LogoutBtn.TabIndex = 30;
            this.LogoutBtn.Text = "Log Out";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(763, -82);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 29;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, -26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Search";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(204, -29);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(228, 22);
            this.SearchBox.TabIndex = 27;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(573, 280);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(115, 23);
            this.UpdateBtn.TabIndex = 26;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(325, 280);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(100, 23);
            this.AddBtn.TabIndex = 24;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-64, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "All Users :";
            // 
            // quickCart_Shop_ManagementDataSet
            // 
            this.quickCart_Shop_ManagementDataSet.DataSetName = "QuickCart_Shop_ManagementDataSet";
            this.quickCart_Shop_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.quickCart_Shop_ManagementDataSet;
            // 
            // ManageProductDGV
            // 
            this.ManageProductDGV.AutoGenerateColumns = false;
            this.ManageProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManageProductDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Name,
            this.Category,
            this.Quantity,
            this.Price,
            this.CreatedBy,
            this.createdAtDataGridViewTextBoxColumn});
            this.ManageProductDGV.DataSource = this.productsBindingSource;
            this.ManageProductDGV.Location = new System.Drawing.Point(9, 335);
            this.ManageProductDGV.Name = "ManageProductDGV";
            this.ManageProductDGV.RowHeadersWidth = 51;
            this.ManageProductDGV.RowTemplate.Height = 24;
            this.ManageProductDGV.Size = new System.Drawing.Size(884, 205);
            this.ManageProductDGV.TabIndex = 21;
            this.ManageProductDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ManageProductDGV_CellContentClick);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 125;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // CreatedBy
            // 
            this.CreatedBy.DataPropertyName = "CreatedBy";
            this.CreatedBy.HeaderText = "CreatedBy";
            this.CreatedBy.MinimumWidth = 6;
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Width = 125;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.quickCart_Shop_ManagementDataSet1;
            // 
            // quickCart_Shop_ManagementDataSet1
            // 
            this.quickCart_Shop_ManagementDataSet1.DataSetName = "QuickCart_Shop_ManagementDataSet1";
            this.quickCart_Shop_ManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(235, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 32);
            this.label8.TabIndex = 45;
            this.label8.Text = "Manage Products";
            // 
            // EXTBTN
            // 
            this.EXTBTN.Location = new System.Drawing.Point(800, 9);
            this.EXTBTN.Name = "EXTBTN";
            this.EXTBTN.Size = new System.Drawing.Size(75, 23);
            this.EXTBTN.TabIndex = 43;
            this.EXTBTN.Text = "Exit";
            this.EXTBTN.UseVisualStyleBackColor = true;
            this.EXTBTN.Click += new System.EventHandler(this.EXTBTN_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "Search";
            // 
            // Seach_box
            // 
            this.Seach_box.Location = new System.Drawing.Point(241, 62);
            this.Seach_box.Name = "Seach_box";
            this.Seach_box.Size = new System.Drawing.Size(228, 22);
            this.Seach_box.TabIndex = 41;
            this.Seach_box.TextChanged += new System.EventHandler(this.Seach_box_TextChanged);
            // 
            // PrNameBox
            // 
            this.PrNameBox.Location = new System.Drawing.Point(220, 108);
            this.PrNameBox.Name = "PrNameBox";
            this.PrNameBox.Size = new System.Drawing.Size(181, 22);
            this.PrNameBox.TabIndex = 46;
            //this.PrNameBox.TextChanged += new System.EventHandler(this.PrNameBox_TextChanged);
            // 
            // PrCategoyBox
            // 
            this.PrCategoyBox.Location = new System.Drawing.Point(220, 145);
            this.PrCategoyBox.Name = "PrCategoyBox";
            this.PrCategoyBox.Size = new System.Drawing.Size(181, 22);
            this.PrCategoyBox.TabIndex = 47;
            //this.PrCategoyBox.TextChanged += new System.EventHandler(this.PrCategoyBox_TextChanged);
            // 
            // PrQuantityBox
            // 
            this.PrQuantityBox.Location = new System.Drawing.Point(220, 185);
            this.PrQuantityBox.Name = "PrQuantityBox";
            this.PrQuantityBox.Size = new System.Drawing.Size(181, 22);
            this.PrQuantityBox.TabIndex = 48;
           //this.PrQuantityBox.TextChanged += new System.EventHandler(this.PrQuantityBox_TextChanged);
            // 
            // PrPriceBox
            // 
            this.PrPriceBox.Location = new System.Drawing.Point(220, 228);
            this.PrPriceBox.Name = "PrPriceBox";
            this.PrPriceBox.Size = new System.Drawing.Size(181, 22);
            this.PrPriceBox.TabIndex = 49;
           // this.PrPriceBox.TextChanged += new System.EventHandler(this.PrPriceBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 53;
            this.label7.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 54;
            this.label10.Text = "All Product List";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(451, 280);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(103, 23);
            this.RemoveBtn.TabIndex = 25;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // srcBtn
            // 
            this.srcBtn.Location = new System.Drawing.Point(493, 62);
            this.srcBtn.Name = "srcBtn";
            this.srcBtn.Size = new System.Drawing.Size(75, 23);
            this.srcBtn.TabIndex = 44;
            this.srcBtn.Text = "Search";
            this.srcBtn.UseVisualStyleBackColor = true;
            this.srcBtn.Click += new System.EventHandler(this.srcBtn_Click);
            // 
            // BackBTn
            // 
            this.BackBTn.Location = new System.Drawing.Point(31, 58);
            this.BackBTn.Name = "BackBTn";
            this.BackBTn.Size = new System.Drawing.Size(75, 23);
            this.BackBTn.TabIndex = 55;
            this.BackBTn.Text = "Back";
            this.BackBTn.UseVisualStyleBackColor = true;
            this.BackBTn.Click += new System.EventHandler(this.BackBTn_Click);
            // 
            // ProductManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(905, 580);
            this.Controls.Add(this.BackBTn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrPriceBox);
            this.Controls.Add(this.PrQuantityBox);
            this.Controls.Add(this.PrCategoyBox);
            this.Controls.Add(this.PrNameBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.srcBtn);
            this.Controls.Add(this.EXTBTN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Seach_box);
            this.Controls.Add(this.AllProductsBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.ManageProductDGV);
            //this.Name = "ProductManagementForm";
            this.Text = "ProductManagementForm";
            this.Load += new System.EventHandler(this.ProductManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quickCart_Shop_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageProductDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickCart_Shop_ManagementDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AllProductsBtn;
        private System.Windows.Forms.Label label4;
        private QuickCart_Shop_ManagementDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label1;
        private QuickCart_Shop_ManagementDataSet quickCart_Shop_ManagementDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.DataGridView ManageProductDGV;
        private QuickCart_Shop_ManagementDataSet1 quickCart_Shop_ManagementDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private QuickCart_Shop_ManagementDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button EXTBTN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Seach_box;
        private System.Windows.Forms.TextBox PrNameBox;
        private System.Windows.Forms.TextBox PrCategoyBox;
        private System.Windows.Forms.TextBox PrQuantityBox;
        private System.Windows.Forms.TextBox PrPriceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button srcBtn;
        private System.Windows.Forms.Button BackBTn;
    }
}