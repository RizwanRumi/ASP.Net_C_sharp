using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonApp
{
    public partial class PersonUI : Form
    {
        Person aPerson;
        public PersonUI()
        {
            InitializeComponent();
        }

        private void showFullNameButton_Click(object sender, EventArgs e)
        {
            aPerson = new Person(firstNameTextBox.Text,middleNameTextBox.Text,lastNameTextBox.Text);
           // SetNames();
            Preson person2 = new Person();
            MessageBox.Show(aPerson.GetFullName());
        }

        //private void SetNames()
        //{
        //    aPerson.firstName = firstNameTextBox.Text;
        //    aPerson.middleName = middleNameTextBox.Text;
        //    aPerson.lastName = lastNameTextBox.Text;
        //}

        private void ameButton_Click(object sender, EventArgs e)
        {
           
         //   aPerson = new Person();
            
            MessageBox.Show(aPerson.GetReverseName());
        }
    }
}
