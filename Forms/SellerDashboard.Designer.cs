namespace QuickCart_Shop_Management.Forms
{
    partial class SellerDashboard
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
            this.CustomerList_Btn = new System.Windows.Forms.Button();
            this.ViewO_Btn = new System.Windows.Forms.Button();
            this.Update_Btn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerList_Btn
            // 
            this.CustomerList_Btn.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerList_Btn.Location = new System.Drawing.Point(518, 173);
            this.CustomerList_Btn.Name = "CustomerList_Btn";
            this.CustomerList_Btn.Size = new System.Drawing.Size(165, 95);
            this.CustomerList_Btn.TabIndex = 29;
            this.CustomerList_Btn.Text = "Customer list";
            this.CustomerList_Btn.UseVisualStyleBackColor = true;
            this.CustomerList_Btn.Click += new System.EventHandler(this.CustomerList_Btn_Click);
            // 
            // ViewO_Btn
            // 
            this.ViewO_Btn.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewO_Btn.Location = new System.Drawing.Point(292, 173);
            this.ViewO_Btn.Name = "ViewO_Btn";
            this.ViewO_Btn.Size = new System.Drawing.Size(151, 95);
            this.ViewO_Btn.TabIndex = 28;
            this.ViewO_Btn.Text = "View Orders";
            this.ViewO_Btn.UseVisualStyleBackColor = true;
            this.ViewO_Btn.Click += new System.EventHandler(this.ViewO_Btn_Click);
            // 
            // Update_Btn
            // 
            this.Update_Btn.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Btn.Location = new System.Drawing.Point(53, 173);
            this.Update_Btn.Name = "Update_Btn";
            this.Update_Btn.Size = new System.Drawing.Size(151, 95);
            this.Update_Btn.TabIndex = 27;
            this.Update_Btn.Text = "Update Product";
            this.Update_Btn.UseVisualStyleBackColor = true;
            this.Update_Btn.Click += new System.EventHandler(this.Update_Btn_Click);
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
            this.label5.Location = new System.Drawing.Point(238, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Seller Dashboard";
            // 
            // SellerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerList_Btn);
            this.Controls.Add(this.ViewO_Btn);
            this.Controls.Add(this.Update_Btn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.label5);
            this.Name = "SellerDashboard";
            this.Text = "SellerDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CustomerList_Btn;
        private System.Windows.Forms.Button ViewO_Btn;
        private System.Windows.Forms.Button Update_Btn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label label5;
    }
}