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
    public partial class StudentUI : Form
    {
        private Department departmentName;
        private Student newStudent;
        private Database aDatabase;
        public StudentUI()
        {
            InitializeComponent();
        }

        private void studentSaveButton_Click(object sender, EventArgs e)
        {
            aDatabase = new Database();
            newStudent = new Student(regTextBox.Text, nameTextBox.Text, emailTextBox.Text);
            string msg = aDatabase.AddStudentInDatabase(regTextBox.Text, nameTextBox.Text, emailTextBox.Text);
            MessageBox.Show(msg);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = aDatabase.fillDataTable("Student");


        }

        //private void StudentUI_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'studentEntryDataSet.Student' table. You can move, or remove it, as needed.
        //    this.studentTableAdapter.Fill(this.studentEntryDataSet.Student);
            

        //}

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //  //   this.studentTableAdapter.Fill(this.studentEntryDataSet.Student);
           
        //    dataGridView1.Rows.Add(newStudent);
        //    dataGridView1.Refresh();
        //}
    }
}
