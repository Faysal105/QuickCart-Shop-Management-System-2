namespace QuickCart_Shop_Management.Forms
{
    partial class AdminDashboard
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
            this.label5 = new System.Windows.Forms.Label();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MngU_Btn = new System.Windows.Forms.Button();
            this.MngP_Btn = new System.Windows.Forms.Button();
            this.Transaction_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Admin Dashboard";
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.LogOutBtn.Location = new System.Drawing.Point(754, 392);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(80, 40);
            this.LogOutBtn.TabIndex = 19;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ExitBtn.Location = new System.Drawing.Point(754, 24);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(80, 40);
            this.ExitBtn.TabIndex = 20;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MngU_Btn
            // 
            this.MngU_Btn.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngU_Btn.Location = new System.Drawing.Point(139, 176);
            this.MngU_Btn.Name = "MngU_Btn";
            this.MngU_Btn.Size = new System.Drawing.Size(151, 95);
            this.MngU_Btn.TabIndex = 21;
            this.MngU_Btn.Text = "Manage User";
            this.MngU_Btn.UseVisualStyleBackColor = true;
            this.MngU_Btn.Click += new System.EventHandler(this.MngU_Btn_Click);
            // 
            // MngP_Btn
            // 
            this.MngP_Btn.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngP_Btn.Location = new System.Drawing.Point(378, 176);
            this.MngP_Btn.Name = "MngP_Btn";
            this.MngP_Btn.Size = new System.Drawing.Size(151, 95);
            this.MngP_Btn.TabIndex = 22;
            this.MngP_Btn.Text = "Manage Product";
            this.MngP_Btn.UseVisualStyleBackColor = true;
            this.MngP_Btn.Click += new System.EventHandler(this.MngP_Btn_Click);
            // 
            // Transaction_Btn
            // 
            this.Transaction_Btn.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction_Btn.Location = new System.Drawing.Point(604, 176);
            this.Transaction_Btn.Name = "Transaction_Btn";
            this.Transaction_Btn.Size = new System.Drawing.Size(165, 95);
            this.Transaction_Btn.TabIndex = 23;
            this.Transaction_Btn.Text = "Transactions";
            this.Transaction_Btn.UseVisualStyleBackColor = true;
            this.Transaction_Btn.Click += new System.EventHandler(this.Transaction_Btn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.Transaction_Btn);
            this.Controls.Add(this.MngP_Btn);
            this.Controls.Add(this.MngU_Btn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.label5);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MngU_Btn;
        private System.Windows.Forms.Button MngP_Btn;
        private System.Windows.Forms.Button Transaction_Btn;
    }
}