using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEntryWithDatabaseApp
{
    public partial class DepartmentUI : Form
    {
        private Department departmentName;
        private Database aDatabase;
        public DepartmentUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aDatabase = new Database();
            departmentName = new Department(codeTextBox.Text,DeptNameTextBox.Text);
            string msg = aDatabase.AddDepartmentInDatabase(codeTextBox.Text, DeptNameTextBox.Text);
            MessageBox.Show(msg);

        }
    }
}
