namespace QuickCart_Shop_Management.Forms
{
    partial class PrintInvoiceForm
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
            this.CashBTn = new System.Windows.Forms.RadioButton();
            this.cardBtn = new System.Windows.Forms.RadioButton();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.paymentMethodtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CashBTn
            // 
            this.CashBTn.AutoSize = true;
            this.CashBTn.Location = new System.Drawing.Point(54, 216);
            this.CashBTn.Name = "CashBTn";
            this.CashBTn.Size = new System.Drawing.Size(59, 20);
            this.CashBTn.TabIndex = 0;
            this.CashBTn.TabStop = true;
            this.CashBTn.Text = "Cash";
            this.CashBTn.UseVisualStyleBackColor = true;
            //this.CashBTn.CheckedChanged += new System.EventHandler(this.CashBTn_CheckedChanged);
            // 
            // cardBtn
            // 
            this.cardBtn.AutoSize = true;
            this.cardBtn.Location = new System.Drawing.Point(119, 216);
            this.cardBtn.Name = "cardBtn";
            this.cardBtn.Size = new System.Drawing.Size(57, 20);
            this.cardBtn.TabIndex = 1;
            this.cardBtn.TabStop = true;
            this.cardBtn.Text = "Card";
            this.cardBtn.UseVisualStyleBackColor = true;
           // this.cardBtn.CheckedChanged += new System.EventHandler(this.cardBtn_CheckedChanged);
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(546, 132);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(161, 22);
            this.TotaltextBox.TabIndex = 2;
           // this.TotaltextBox.TextChanged += new System.EventHandler(this.TotaltextBox_TextChanged);
            // 
            // paymentMethodtextBox
            // 
            this.paymentMethodtextBox.Location = new System.Drawing.Point(546, 175);
            this.paymentMethodtextBox.Name = "paymentMethodtextBox";
            this.paymentMethodtextBox.Size = new System.Drawing.Size(161, 22);
            this.paymentMethodtextBox.TabIndex = 3;
           // this.paymentMethodtextBox.TextChanged += new System.EventHandler(this.paymentMethodtextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Payment Method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Payment Method";
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(546, 225);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(82, 28);
            this.PrintBtn.TabIndex = 8;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(616, 54);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(91, 42);
            this.Exitbtn.TabIndex = 9;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(54, 54);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(91, 42);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // PrintInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 279);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymentMethodtextBox);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.cardBtn);
            this.Controls.Add(this.CashBTn);
            this.Name = "PrintInvoiceForm";
            this.Text = "PrintInvoiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton CashBTn;
        private System.Windows.Forms.RadioButton cardBtn;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.TextBox paymentMethodtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button BackBtn;
    }
}