using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    public partial class AccountOpperationUI : Form
    {
        Customer abankCustomer = new Customer();
         
        public AccountOpperationUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //abankCustomer.accountNumber = accountNumberTextBox.Text;
            //abankCustomer.customerName = customrNameTextBox.Text;
            string newNumber = accountNumberTextBox.Text;
            abankCustomer.SetNumber(newNumber);
            MessageBox.Show(abankCustomer.GetNumber());
            
        }

        
        

        private void DepositButton_Click(object sender, EventArgs e)
        {
            double depositAmount = setConvertAmount();
            MessageBox.Show(abankCustomer.DepositAccount(depositAmount));
           
        }

        public double setConvertAmount()
        {
            return abankCustomer.deposit = Convert.ToDouble(amountTextBox.Text);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {

            double withdrawAmount = setConvertAmount();
            MessageBox.Show(abankCustomer.WithdrawAccount(withdrawAmount));
            
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
           MessageBox.Show(abankCustomer.Report());
        }

    }
}









