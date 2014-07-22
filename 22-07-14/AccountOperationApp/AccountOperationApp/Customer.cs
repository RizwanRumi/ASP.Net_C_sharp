using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    class Customer
    {
        private string number;
        private string Name;

        public double deposit;
        public double withdraw;
        public double Total;

        public void SetNumber(string newNumber)
        {
            number = newNumber;
        }

        public string GetNumber()
        {
            return number;
        }
        public string GetAccount()
        {
            return "Create Account Successfully";
        }
       
        public string DepositAccount(double depositAmount)
        {
            if (depositAmount <= 0)
            {
                Total = depositAmount;
                return "Your deposit is : " + Total.ToString();
            }
            else
            {
                Total += depositAmount;
                return  "your diposit is " + Total.ToString();
            }
            
        }

        public string WithdrawAccount(double withdrawAmount)
        {
            
            if (withdrawAmount > Total)
            {
                return "you can't withdraw,cause your deposit have " + Total.ToString();
            }
            else
            {
                Total -= withdrawAmount; 
                return "your current deposit is now : " + Total.ToString();
                
            }
        }
        
        public string Report()
        {
            
             return (" Name: " + Name + "\n account No : " + number + "\n Deposit is : " + Total.ToString());
            
                
        }
    }
}
