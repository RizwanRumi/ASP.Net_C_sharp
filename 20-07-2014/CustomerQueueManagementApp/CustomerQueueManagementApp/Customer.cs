using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerQueueManagementApp
{
    class Customer
    {
        public string serialNo;
        public string customerName;
        public string customerComplain;
       

        public string GetName()
        {
            return  (customerName +"'s serial number is "+ serialNo) ;
        }
    }
}
