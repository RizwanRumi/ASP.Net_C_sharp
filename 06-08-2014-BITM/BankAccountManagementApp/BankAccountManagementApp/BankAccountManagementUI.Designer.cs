namespace BankAccountManagementApp
{
    partial class BankAccountManagementUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerSaveButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nationalIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.customerInAccountComboBox = new System.Windows.Forms.ComboBox();
            this.accountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.accountSaveButton = new System.Windows.Forms.Button();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.amountInTransactionTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.accountInTransactionComboBox = new System.Windows.Forms.ComboBox();
            this.customerInTransactionComboBox = new System.Windows.Forms.ComboBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.customerInReportComboBox = new System.Windows.Forms.ComboBox();
            this.showAccountDetailsButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customerSaveButton);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nationalIdTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 232);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // customerSaveButton
            // 
            this.customerSaveButton.Location = new System.Drawing.Point(148, 198);
            this.customerSaveButton.Name = "customerSaveButton";
            this.customerSaveButton.Size = new System.Drawing.Size(75, 23);
            this.customerSaveButton.TabIndex = 4;
            this.customerSaveButton.Text = "Save";
            this.customerSaveButton.UseVisualStyleBackColor = true;
            this.customerSaveButton.Click += new System.EventHandler(this.customerSaveButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(91, 145);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(201, 37);
            this.addressTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(91, 108);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(201, 20);
            this.phoneTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(91, 67);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(201, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Present Address";
            // 
            // nationalIdTextBox
            // 
            this.nationalIdTextBox.Location = new System.Drawing.Point(91, 30);
            this.nationalIdTextBox.Name = "nationalIdTextBox";
            this.nationalIdTextBox.Size = new System.Drawing.Size(201, 20);
            this.nationalIdTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "National Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.customerInAccountComboBox);
            this.groupBox2.Controls.Add(this.accountTypeComboBox);
            this.groupBox2.Controls.Add(this.accountSaveButton);
            this.groupBox2.Controls.Add(this.accountNumberTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 182);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Information";
            // 
            // customerInAccountComboBox
            // 
            this.customerInAccountComboBox.FormattingEnabled = true;
            this.customerInAccountComboBox.Location = new System.Drawing.Point(99, 105);
            this.customerInAccountComboBox.Name = "customerInAccountComboBox";
            this.customerInAccountComboBox.Size = new System.Drawing.Size(193, 21);
            this.customerInAccountComboBox.TabIndex = 2;
            // 
            // accountTypeComboBox
            // 
            this.accountTypeComboBox.FormattingEnabled = true;
            this.accountTypeComboBox.Items.AddRange(new object[] {
            "Saving",
            "Checking"});
            this.accountTypeComboBox.Location = new System.Drawing.Point(99, 67);
            this.accountTypeComboBox.Name = "accountTypeComboBox";
            this.accountTypeComboBox.Size = new System.Drawing.Size(193, 21);
            this.accountTypeComboBox.TabIndex = 1;
            // 
            // accountSaveButton
            // 
            this.accountSaveButton.Location = new System.Drawing.Point(148, 144);
            this.accountSaveButton.Name = "accountSaveButton";
            this.accountSaveButton.Size = new System.Drawing.Size(75, 23);
            this.accountSaveButton.TabIndex = 3;
            this.accountSaveButton.Text = "Save";
            this.accountSaveButton.UseVisualStyleBackColor = true;
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(99, 30);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(193, 20);
            this.accountNumberTextBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Customer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Account Number";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.amountInTransactionTextBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.accountInTransactionComboBox);
            this.groupBox3.Controls.Add(this.customerInTransactionComboBox);
            this.groupBox3.Controls.Add(this.depositButton);
            this.groupBox3.Controls.Add(this.withdrawButton);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(338, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 182);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction In Account";
            // 
            // amountInTransactionTextBox
            // 
            this.amountInTransactionTextBox.Location = new System.Drawing.Point(90, 108);
            this.amountInTransactionTextBox.Name = "amountInTransactionTextBox";
            this.amountInTransactionTextBox.Size = new System.Drawing.Size(200, 20);
            this.amountInTransactionTextBox.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Amount";
            // 
            // accountInTransactionComboBox
            // 
            this.accountInTransactionComboBox.FormattingEnabled = true;
            this.accountInTransactionComboBox.Location = new System.Drawing.Point(90, 67);
            this.accountInTransactionComboBox.Name = "accountInTransactionComboBox";
            this.accountInTransactionComboBox.Size = new System.Drawing.Size(200, 21);
            this.accountInTransactionComboBox.TabIndex = 1;
            // 
            // customerInTransactionComboBox
            // 
            this.customerInTransactionComboBox.FormattingEnabled = true;
            this.customerInTransactionComboBox.Location = new System.Drawing.Point(90, 37);
            this.customerInTransactionComboBox.Name = "customerInTransactionComboBox";
            this.customerInTransactionComboBox.Size = new System.Drawing.Size(200, 21);
            this.customerInTransactionComboBox.TabIndex = 0;
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(40, 144);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 3;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(175, 143);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 4;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Account";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Customer";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.customerInReportComboBox);
            this.groupBox4.Controls.Add(this.showAccountDetailsButton);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(338, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(309, 115);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Report";
            // 
            // customerInReportComboBox
            // 
            this.customerInReportComboBox.FormattingEnabled = true;
            this.customerInReportComboBox.Location = new System.Drawing.Point(74, 37);
            this.customerInReportComboBox.Name = "customerInReportComboBox";
            this.customerInReportComboBox.Size = new System.Drawing.Size(216, 21);
            this.customerInReportComboBox.TabIndex = 0;
            // 
            // showAccountDetailsButton
            // 
            this.showAccountDetailsButton.Location = new System.Drawing.Point(74, 79);
            this.showAccountDetailsButton.Name = "showAccountDetailsButton";
            this.showAccountDetailsButton.Size = new System.Drawing.Size(136, 23);
            this.showAccountDetailsButton.TabIndex = 1;
            this.showAccountDetailsButton.Text = "Show Account Info";
            this.showAccountDetailsButton.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Customer";
            // 
            // BankAccountManagementUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 454);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BankAccountManagementUI";
            this.Text = "BankAccountManagementUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button customerSaveButton;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nationalIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox customerInAccountComboBox;
        private System.Windows.Forms.ComboBox accountTypeComboBox;
        private System.Windows.Forms.Button accountSaveButton;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox amountInTransactionTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox accountInTransactionComboBox;
        private System.Windows.Forms.ComboBox customerInTransactionComboBox;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox customerInReportComboBox;
        private System.Windows.Forms.Button showAccountDetailsButton;
        private System.Windows.Forms.Label label13;
    }
}

