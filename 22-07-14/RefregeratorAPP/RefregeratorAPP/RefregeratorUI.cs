using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefregeratorAPP
{
    public partial class RefregeratorUI : Form
    {
       private Refregerator aRefregerator;
        
        public RefregeratorUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aRefregerator = new Refregerator();
            aRefregerator.MaxWeight = Convert.ToDouble(maxweightTextBox.Text);

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
           int noOfItems = Convert.ToInt16(noOfItemsTextBox.Text);
           double weight = Convert.ToDouble(weightTextBox.Text);
            
            try
            {
                aRefregerator.AddItems(noOfItems , weight);
                currentWeightTextBox.Text = aRefregerator.CurrentWeight.ToString();
                remainmingWeightTextBox.Text = aRefregerator.RemainingWeight.ToString();
            }
            catch (Exception exceptionObj)
            {

                MessageBox.Show(exceptionObj.Message);
            }
            

        }
    }
}
