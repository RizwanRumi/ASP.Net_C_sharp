using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountManagementApp
{
    public partial class BankAccountManagementUI : Form
    {
        
        public BankAccountManagementUI()
        {
            InitializeComponent();

            customerInAccountComboBox.DisplayMember = "Name";
            customerInTransactionComboBox.DisplayMember = "Name";
            customerInReportComboBox.DisplayMember = "Name";
        }

        private void customerSaveButton_Click(object sender, EventArgs e)
        {
           Customer aCustomer = new Customer(nationalIdTextBox.Text,nameTextBox.Text,phoneTextBox.Text,addressTextBox.Text);
            customerInAccountComboBox.Items.Add(aCustomer);
            customerInTransactionComboBox.Items.Add(aCustomer);
            customerInReportComboBox.Items.Add(aCustomer);
            MessageBox.Show("saved Customer");
        }
    }
}
