namespace QuickCart_Shop_Management.Forms
{
    partial class CustomerDashboard
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
            this.MyOrder_Btn = new System.Windows.Forms.Button();
            this.Cart_Btn = new System.Windows.Forms.Button();
            this.BrowseP_Btn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MyOrder_Btn
            // 
            this.MyOrder_Btn.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyOrder_Btn.Location = new System.Drawing.Point(518, 173);
            this.MyOrder_Btn.Name = "MyOrder_Btn";
            this.MyOrder_Btn.Size = new System.Drawing.Size(165, 95);
            this.MyOrder_Btn.TabIndex = 29;
            this.MyOrder_Btn.Text = "My Orders";
            this.MyOrder_Btn.UseVisualStyleBackColor = true;
            this.MyOrder_Btn.Click += new System.EventHandler(this.MyOrder_Btn_Click);
            // 
            // Cart_Btn
            // 
            this.Cart_Btn.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cart_Btn.Location = new System.Drawing.Point(292, 173);
            this.Cart_Btn.Name = "Cart_Btn";
            this.Cart_Btn.Size = new System.Drawing.Size(151, 95);
            this.Cart_Btn.TabIndex = 28;
            this.Cart_Btn.Text = "Cart";
            this.Cart_Btn.UseVisualStyleBackColor = true;
            this.Cart_Btn.Click += new System.EventHandler(this.Cart_Btn_Click);
            // 
            // BrowseP_Btn
            // 
            this.BrowseP_Btn.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseP_Btn.Location = new System.Drawing.Point(53, 173);
            this.BrowseP_Btn.Name = "BrowseP_Btn";
            this.BrowseP_Btn.Size = new System.Drawing.Size(151, 95);
            this.BrowseP_Btn.TabIndex = 27;
            this.BrowseP_Btn.Text = "Browse Product";
            this.BrowseP_Btn.UseVisualStyleBackColor = true;
            this.BrowseP_Btn.Click += new System.EventHandler(this.BrowseP_Btn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ExitBtn.Location = new System.Drawing.Point(668, 21);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(80, 40);
            this.ExitBtn.TabIndex = 26;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.LogOutBtn.Location = new System.Drawing.Point(668, 389);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(80, 40);
            this.LogOutBtn.TabIndex = 25;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Customer Dashboard";
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MyOrder_Btn);
            this.Controls.Add(this.Cart_Btn);
            this.Controls.Add(this.BrowseP_Btn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.label5);
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MyOrder_Btn;
        private System.Windows.Forms.Button Cart_Btn;
        private System.Windows.Forms.Button BrowseP_Btn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label label5;
    }
}