using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    class Account
    {
        private string number;
        private string name;
        private double balance =0;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public Account(string number, string name) : this()
        {
            this.name = name;
            this.number = number;
        }

        public Account()
        {
            this.balance = 0;
        }
        public string Deposit(double amount)
        {
            balance = Balance + amount;
            return "Deposited";
        }

        public string Withdraw(double amount)
        {
            balance = Balance - amount;
            return "Withdrawn";
        }

    }
}
