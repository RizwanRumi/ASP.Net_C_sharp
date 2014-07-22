using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    public partial class VehicleUI : Form
    {
        Vehicle aVehicleinfo = new Vehicle();
        public VehicleUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            aVehicleinfo.name = nameTextBox.Text;
            aVehicleinfo.reg = regTextBox.Text;
            MessageBox.Show("account created");
        }

       

        private void enterButton_Click(object sender, EventArgs e)
        {
            aVehicleinfo.speedEntry = Convert.ToDouble(speedTextBox.Text);

            //aVehicleinfo.currentSpeed = aVehicleinfo.speedEntry;
            double entrySpeed = aVehicleinfo.speedEntry;
            aVehicleinfo.GetSpeed(double entrySpeed);
            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = aVehicleinfo.GetMinSpeed().ToString();
            maxSpeedTextBox.Text = aVehicleinfo.GetMaxSpeed().ToString();
        }

     


        
    }
}
