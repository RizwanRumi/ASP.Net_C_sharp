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
    public partial class StudentEntryWithDatabaseUI : Form
    {

        public StudentEntryWithDatabaseUI()
        {
            InitializeComponent();
        }

        private void departmentEntryButton_Click(object sender, EventArgs e)
        {
            DepartmentUI aDepartmentUi = new DepartmentUI();
            aDepartmentUi.Show();
        }

        private void studentEntryButton_Click(object sender, EventArgs e)
        {
            StudentUI aStudentUi = new StudentUI();
            aStudentUi.Show();
        }
    }
}
