using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementApp
{
    class Customer
    {
       
       
        public Customer(string nationalId, string name, string phone, string address)
        {
            NationalId = nationalId;
            Name = name;
            Phone = phone;
            Address = address;
        }


        public string NationalId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
