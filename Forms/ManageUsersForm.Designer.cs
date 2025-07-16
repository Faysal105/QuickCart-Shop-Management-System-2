namespace QuickCart_Shop_Management.Forms
{
    partial class ManageUsersForm
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
            this.ManageUserDGV = new System.Windows.Forms.DataGridView();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quickCart_Shop_ManagementDataSet = new QuickCart_Shop_Management.QuickCart_Shop_ManagementDataSet();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.RolecomboBox = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.usersTableAdapter = new QuickCart_Shop_Management.QuickCart_Shop_ManagementDataSetTableAdapters.UsersTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.AllUsersBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.FullnameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.productsTableAdapter = new QuickCart_Shop_Management.QuickCart_Shop_ManagementDataSetTableAdapters.ProductsTableAdapter();
            this.userLoginTableAdapter = new QuickCart_Shop_Management.QuickCart_Shop_ManagementDataSetTableAdapters.UserLoginTableAdapter();
            this.rolesTableAdapter = new QuickCart_Shop_Management.QuickCart_Shop_ManagementDataSetTableAdapters.RolesTableAdapter();
            this.Homebtn = new System.Windows.Forms.Button();
            this.fKProductsCreate44FF419ABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKUserLoginUserI403A8C7DBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ManageUserDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickCart_Shop_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductsCreate44FF419ABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKUserLoginUserI403A8C7DBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageUserDGV
            // 
            this.ManageUserDGV.AutoGenerateColumns = false;
            this.ManageUserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManageUserDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.Username,
            this.Password,
            this.FullName,
            this.IsActive,
            this.CreatedAt});
            this.ManageUserDGV.DataSource = this.usersBindingSource;
            this.ManageUserDGV.Location = new System.Drawing.Point(15, 382);
            this.ManageUserDGV.Name = "ManageUserDGV";
            this.ManageUserDGV.RowHeadersWidth = 51;
            this.ManageUserDGV.RowTemplate.Height = 24;
            this.ManageUserDGV.Size = new System.Drawing.Size(928, 205);
            this.ManageUserDGV.TabIndex = 0;
            this.ManageUserDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ManageUserDGV_CellContentClick);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.quickCart_Shop_ManagementDataSet;
            // 
            // quickCart_Shop_ManagementDataSet
            // 
            this.quickCart_Shop_ManagementDataSet.DataSetName = "QuickCart_Shop_ManagementDataSet";
            this.quickCart_Shop_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.quickCart_Shop_ManagementDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Users :";
            // 
            // RolecomboBox
            // 
            this.RolecomboBox.FormattingEnabled = true;
            this.RolecomboBox.Items.AddRange(new object[] {
            "Customers",
            "Sellers",
            "Admins"});
            this.RolecomboBox.Location = new System.Drawing.Point(166, 308);
            this.RolecomboBox.Name = "RolecomboBox";
            this.RolecomboBox.Size = new System.Drawing.Size(121, 24);
            this.RolecomboBox.TabIndex = 2;
            this.RolecomboBox.SelectedIndexChanged += new System.EventHandler(this.RolecomboBox_SelectedIndexChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(425, 337);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(100, 23);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(551, 337);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(103, 23);
            this.RemoveBtn.TabIndex = 4;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(673, 337);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(115, 23);
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(283, 65);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(228, 22);
            this.SearchBox.TabIndex = 6;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(842, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(842, 603);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(101, 23);
            this.LogoutBtn.TabIndex = 9;
            this.LogoutBtn.Text = "Log Out";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Roles :";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(535, 65);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 12;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Manage Users";
            // 
            // AllUsersBtn
            // 
            this.AllUsersBtn.Location = new System.Drawing.Point(817, 337);
            this.AllUsersBtn.Name = "AllUsersBtn";
            this.AllUsersBtn.Size = new System.Drawing.Size(124, 23);
            this.AllUsersBtn.TabIndex = 14;
            this.AllUsersBtn.Text = "All Users";
            this.AllUsersBtn.UseVisualStyleBackColor = true;
            this.AllUsersBtn.Click += new System.EventHandler(this.AllUsersBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Full Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Username :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password : ";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(166, 151);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(228, 22);
            this.UsernameBox.TabIndex = 18;
            // 
            // FullnameBox
            // 
            this.FullnameBox.Location = new System.Drawing.Point(166, 194);
            this.FullnameBox.Name = "FullnameBox";
            this.FullnameBox.Size = new System.Drawing.Size(228, 22);
            this.FullnameBox.TabIndex = 19;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(166, 235);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(228, 22);
            this.PasswordBox.TabIndex = 20;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // userLoginTableAdapter
            // 
            this.userLoginTableAdapter.ClearBeforeFill = true;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // Homebtn
            // 
            this.Homebtn.Location = new System.Drawing.Point(67, 68);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(75, 23);
            this.Homebtn.TabIndex = 21;
            this.Homebtn.Text = "Home";
            this.Homebtn.UseVisualStyleBackColor = true;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // fKProductsCreate44FF419ABindingSource
            // 
            this.fKProductsCreate44FF419ABindingSource.DataMember = "FK__Products__Create__44FF419A";
            this.fKProductsCreate44FF419ABindingSource.DataSource = this.usersBindingSource;
            // 
            // fKUserLoginUserI403A8C7DBindingSource
            // 
            this.fKUserLoginUserI403A8C7DBindingSource.DataMember = "FK__UserLogin__UserI__403A8C7D";
            this.fKUserLoginUserI403A8C7DBindingSource.DataSource = this.usersBindingSource;
            // 
            // UserID
            // 
            this.UserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "FullName";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            // 
            // IsActive
            // 
            this.IsActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "IsActive";
            this.IsActive.MinimumWidth = 6;
            this.IsActive.Name = "IsActive";
            // 
            // CreatedAt
            // 
            this.CreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "CreatedAt";
            this.CreatedAt.MinimumWidth = 6;
            this.CreatedAt.Name = "CreatedAt";
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(963, 655);
            this.Controls.Add(this.Homebtn);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.FullnameBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AllUsersBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.RolecomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManageUserDGV);
            this.Name = "ManageUsersForm";
            this.Text = "ManageUsersForm";
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManageUserDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickCart_Shop_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductsCreate44FF419ABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKUserLoginUserI403A8C7DBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ManageUserDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RolecomboBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchBtn;
        private QuickCart_Shop_ManagementDataSet quickCart_Shop_ManagementDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private QuickCart_Shop_ManagementDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AllUsersBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox FullnameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.BindingSource fKProductsCreate44FF419ABindingSource;
        private QuickCart_Shop_ManagementDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource fKUserLoginUserI403A8C7DBindingSource;
        private QuickCart_Shop_ManagementDataSetTableAdapters.UserLoginTableAdapter userLoginTableAdapter;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private QuickCart_Shop_ManagementDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.Button Homebtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
    }
}