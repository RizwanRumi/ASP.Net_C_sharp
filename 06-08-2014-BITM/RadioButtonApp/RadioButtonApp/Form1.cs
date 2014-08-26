using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("You have Selected ASP.NET");
            if (radioButton2.Checked)
                MessageBox.Show("You have Selected Unity");
            if (radioButton3.Checked)
                MessageBox.Show("You have Selected Laravel");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Display the selected date and time:
            MessageBox.Show("Your've selected the meeting date: "
            + dateTimePicker1.Value.Date);

            // Display today's date and time:
            //MessageBox.Show("Today is: " + DateTime.Today);
        }
    }
}
