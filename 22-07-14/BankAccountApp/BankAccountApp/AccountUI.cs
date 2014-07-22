using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountApp
{
    public partial class AccountUI : Form
    {
        private Account anAccount;
        private double amount;
        private string msg;

        public AccountUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            anAccount = new Account(customerNameTextBox.Text,accountNumberTextBox.Text);
            anAccount = new Account();
          //  anAccount.Name = customerNameTextBox.Text;
         //   anAccount.Number = accountNumberTextBox.Text;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTextBox.Text);
            msg = anAccount.Deposit(amount);

            //anAccount.Balance = anAccount.Balance + amount;
            
            MessageBox.Show(msg);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTextBox.Text);
            msg = anAccount.Withdraw(amount);
            MessageBox.Show(msg);

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            
            msg = anAccount.Name + ", your acc no: " + anAccount.Number + " and it's balance is: " + anAccount.Balance;
            MessageBox.Show(msg);
        }
    }
}
