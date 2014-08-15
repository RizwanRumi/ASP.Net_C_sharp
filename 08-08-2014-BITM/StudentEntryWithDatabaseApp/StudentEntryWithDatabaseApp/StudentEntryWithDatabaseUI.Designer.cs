namespace StudentEntryWithDatabaseApp
{
    partial class StudentEntryWithDatabaseUI
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
            this.departmentEntryButton = new System.Windows.Forms.Button();
            this.studentEntryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // departmentEntryButton
            // 
            this.departmentEntryButton.Location = new System.Drawing.Point(24, 32);
            this.departmentEntryButton.Name = "departmentEntryButton";
            this.departmentEntryButton.Size = new System.Drawing.Size(216, 64);
            this.departmentEntryButton.TabIndex = 0;
            this.departmentEntryButton.Text = "Department Entry";
            this.departmentEntryButton.UseVisualStyleBackColor = true;
            this.departmentEntryButton.Click += new System.EventHandler(this.departmentEntryButton_Click);
            // 
            // studentEntryButton
            // 
            this.studentEntryButton.Location = new System.Drawing.Point(24, 124);
            this.studentEntryButton.Name = "studentEntryButton";
            this.studentEntryButton.Size = new System.Drawing.Size(216, 62);
            this.studentEntryButton.TabIndex = 0;
            this.studentEntryButton.Text = "Student Entry";
            this.studentEntryButton.UseVisualStyleBackColor = true;
            this.studentEntryButton.Click += new System.EventHandler(this.studentEntryButton_Click);
            // 
            // StudentEntryWithDatabaseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.studentEntryButton);
            this.Controls.Add(this.departmentEntryButton);
            this.Name = "StudentEntryWithDatabaseUI";
            this.Text = "StudentEntryWithDatabaseUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button departmentEntryButton;
        private System.Windows.Forms.Button studentEntryButton;
    }
}

