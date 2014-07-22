using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    class Customer
    {
        public string accountNumber;
        public string customerName;
        
        public double total = 0;
     
        public string customerInfo()
        {
            return customerName + ", " + accountNumber + " and Balance is ";
        }

        public void Deposit(double depositAmount)
        {
            if (Math.Abs(depositAmount) <= 0)
            {
                total = depositAmount;
                MessageBox.Show("your diposit is " + total);
            }
            else
            {
                total += depositAmount;
                MessageBox.Show("your diposit is " + total);
            }
            
        }

        public void Withdraw(double withdrawAmount)
        {
            if (Math.Abs(withdrawAmount) == 0)
                MessageBox.Show("your current diposit " + total);
            else
            {
                double totalAmount = total - withdrawAmount;
                if (totalAmount < 0)
                    MessageBox.Show("You can't withdraw, cause your deposit is " + total);
                else
                {
                    MessageBox.Show("your current deposit is now : " + totalAmount);
                    total = totalAmount;
                }
            }
        }

        public void Report()
        {
            MessageBox.Show(customerInfo() + ", account Number " + accountNumber + " & Deposit " + total);
            double finalAmount;
        }
    }
}
