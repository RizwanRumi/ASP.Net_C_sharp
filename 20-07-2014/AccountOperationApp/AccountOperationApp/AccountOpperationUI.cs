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
        private double deposit = 0;  
        public AccountOpperationUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            abankCustomer.accountNumber = accountNumberTextBox.Text;
            abankCustomer.customerName = customrNameTextBox.Text;

            if (abankCustomer.accountNumber != "" && abankCustomer.customerName != "")
            {
                MessageBox.Show("Account created");
            }
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            //if (amountTextBox.Text == "")
            //    MessageBox.Show("your current diposit " + deposit);
            //else
            //{
            //    abankCustomer.amount = Convert.ToDouble(amountTextBox.Text);
            //    double totalDiposit = deposit + abankCustomer.amount;
            //    MessageBox.Show("your current deposit is : " + totalDiposit);
            //    deposit = totalDiposit;
            //}

            // in class.................
            double inputDeposit = Convert.ToDouble(amountTextBox.Text);
            abankCustomer.Deposit(inputDeposit);
           
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            //if (amountTextBox.Text == "")
            //    MessageBox.Show("your current diposit " + deposit);
            //else
            //{
            //    abankCustomer.amount = Convert.ToDouble(amountTextBox.Text);
            //    double totalDiposit = deposit - abankCustomer.amount;
            //    if (totalDiposit < 0)
            //        MessageBox.Show("You can't withdraw, cause your deposit is " + deposit);
            //    else
            //        MessageBox.Show("your current deposit is now : " + totalDiposit);
                
            //    deposit = totalDiposit;
            //}

            //in class........
            double withdrawAmount = Convert.ToDouble(amountTextBox.Text);
            abankCustomer.Withdraw(withdrawAmount);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(abankCustomer.customerInfo()+", account Number "+ abankCustomer.accountNumber+  " & Deposit " + deposit);
           
            // in class ........
            abankCustomer.Report();
        }

    }
}









