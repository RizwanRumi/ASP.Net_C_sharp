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
            this.sellItemButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sellQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sellProductIdTextBox = new System.Windows.Forms.TextBox();
            this.sellItemdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sellItemdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sellItemButton
            // 
            this.sellItemButton.Location = new System.Drawing.Point(137, 73);
            this.sellItemButton.Name = "sellItemButton";
            this.sellItemButton.Size = new System.Drawing.Size(75, 23);
            this.sellItemButton.TabIndex = 9;
            this.sellItemButton.Text = "Sell Item";
            this.sellItemButton.UseVisualStyleBackColor = true;
            this.sellItemButton.Click += new System.EventHandler(this.sellItemButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "quantity";
            // 
            // sellQuantityTextBox
            // 
            this.sellQuantityTextBox.Location = new System.Drawing.Point(81, 36);
            this.sellQuantityTextBox.Name = "sellQuantityTextBox";
            this.sellQuantityTextBox.Size = new System.Drawing.Size(132, 20);
            this.sellQuantityTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product/Item ID";
            // 
            // sellProductIdTextBox
            // 
            this.sellProductIdTextBox.Location = new System.Drawing.Point(98, 0);
            this.sellProductIdTextBox.Name = "sellProductIdTextBox";
            this.sellProductIdTextBox.Size = new System.Drawing.Size(132, 20);
            this.sellProductIdTextBox.TabIndex = 8;
            // 
            // sellItemdataGridView
            // 
            this.sellItemdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellItemdataGridView.Location = new System.Drawing.Point(21, 131);
            this.sellItemdataGridView.Name = "sellItemdataGridView";
            this.sellItemdataGridView.Size = new System.Drawing.Size(240, 150);
            this.sellItemdataGridView.TabIndex = 10;
            // 
            // SellItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 403);
            this.Controls.Add(this.sellItemdataGridView);
            this.Controls.Add(this.sellItemButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sellQuantityTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sellProductIdTextBox);
            this.Name = "SellItemUI";
            this.Text = "SellItemUI";
            ((System.ComponentModel.ISupportInitialize)(this.sellItemdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sellItemButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sellQuantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sellProductIdTextBox;
        private System.Windows.Forms.DataGridView sellItemdataGridView;
    }
}