using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingApp
{
    public partial class GradingUI : Form
    {
        Result aStudentMark = new Result();
        private  string aPlus = "A+";
        private string bPlus = "B+";
        private string cPlus = "C+";
        private string dPlus = "D+";
        private string f = "F";
        public GradingUI()
        {
            InitializeComponent();
        }

        private void showsButton_Click(object sender, EventArgs e)
        {
            SetResult();
            double getMark = aStudentMark.GetResult();
            if (getMark >= 80.0 && getMark <= 100.0)
            {
                averageTextBox.Text = aStudentMark.average.ToString();
                gradeLetterTextBox.Text = aPlus;
            }

            else if (getMark >= 70.0 && getMark < 80.0)
            {
                averageTextBox.Text = aStudentMark.average.ToString();
                gradeLetterTextBox.Text = bPlus;
            }

            else if (getMark >= 60.0 && getMark < 70.0)
            {
                averageTextBox.Text = aStudentMark.average.ToString();
                gradeLetterTextBox.Text = cPlus;
            }
            else if (getMark >= 50.0 && getMark < 60.0)
            {
                averageTextBox.Text = aStudentMark.average.ToString();
                gradeLetterTextBox.Text = dPlus;
            }
            else
            {
                averageTextBox.Text = aStudentMark.average.ToString();
                gradeLetterTextBox.Text = f;
            }
        }

        public void SetResult()
        {
            aStudentMark.physics = Convert.ToDouble(physicsTextBox.Text);
            aStudentMark.chemistry = Convert.ToDouble(chemistryTextBox.Text);
            aStudentMark.math = Convert.ToDouble(mathTextBox.Text);
        }

        

    }
}
