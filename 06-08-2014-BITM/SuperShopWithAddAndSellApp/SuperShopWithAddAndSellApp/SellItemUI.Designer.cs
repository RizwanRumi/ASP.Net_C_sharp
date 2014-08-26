namespace SuperShopWithAddAndSellApp
{
    partial class SellItemUI
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addItemListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sellItemButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sellQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sellProductIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addItemListView);
            this.groupBox2.Controls.Add(this.sellItemButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.sellQuantityTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.sellProductIdTextBox);
            this.groupBox2.Location = new System.Drawing.Point(21, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 311);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "product Info";
            // 
            // addItemListView
            // 
            this.addItemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.addItemListView.Location = new System.Drawing.Point(19, 145);
            this.addItemListView.Name = "addItemListView";
            this.addItemListView.Size = new System.Drawing.Size(283, 146);
            this.addItemListView.TabIndex = 4;
            this.addItemListView.UseCompatibleStateImageBehavior = false;
            this.addItemListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product ID";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 151;
            // 
            // sellItemButton
            // 
            this.sellItemButton.Location = new System.Drawing.Point(144, 101);
            this.sellItemButton.Name = "sellItemButton";
            this.sellItemButton.Size = new System.Drawing.Size(75, 23);
            this.sellItemButton.TabIndex = 3;
            this.sellItemButton.Text = "Sell Item";
            this.sellItemButton.UseVisualStyleBackColor = true;
            this.sellItemButton.Click += new System.EventHandler(this.sellItemButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "quantity";
            // 
            // sellQuantityTextBox
            // 
            this.sellQuantityTextBox.Location = new System.Drawing.Point(88, 64);
            this.sellQuantityTextBox.Name = "sellQuantityTextBox";
            this.sellQuantityTextBox.Size = new System.Drawing.Size(132, 20);
            this.sellQuantityTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product/Item ID";
            // 
            // sellProductIdTextBox
            // 
            this.sellProductIdTextBox.Location = new System.Drawing.Point(88, 27);
            this.sellProductIdTextBox.Name = "sellProductIdTextBox";
            this.sellProductIdTextBox.Size = new System.Drawing.Size(132, 20);
            this.sellProductIdTextBox.TabIndex = 2;
            // 
            // SellItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 359);
            this.Controls.Add(this.groupBox2);
            this.Name = "SellItemUI";
            this.Text = "SellItemUI";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView addItemListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button sellItemButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sellQuantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sellProductIdTextBox;
    }
}