using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEntryFormApp
{
    public partial class StudentEntryUI : Form
    {
        private Department departmentName;
        private Student newStudent;
        public StudentEntryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            departmentName = new Department(codeTextBox.Text, DeptNameTextBox.Text);
            MessageBox.Show("Department saved");
        }

        private void studentSaveButton_Click(object sender, EventArgs e)
        {

            newStudent = new Student(regTextBox.Text, nameTextBox.Text, emailTextBox.Text);

            MessageBox.Show(departmentName.Addstudent(newStudent));
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string msg = "dept Id: " + departmentName.Code + " dept. name : " + departmentName.DeptName + "\n" +
                      "Reg no:\t Name \t email \n";

            foreach (KeyValuePair<string, Student> astudent in departmentName.GetStudentList())
            {
                msg += astudent.Value.RegNo + "\t" + astudent.Value.Name +"\t" + astudent.Value.Email +"\n";
            }

            MessageBox.Show(msg);
        }

        
    }
}
