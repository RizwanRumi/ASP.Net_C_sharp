using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person aPerson = new Person();
            //aPerson.firstName = "James";
            //aPerson.middleName = "Locus";
            //aPerson.lastName = "Scott";

            //string fullName = aPerson.GetFullName();
            //string reverseName = aPerson.GetReverseName();

            //Console.WriteLine(fullName);
            //Console.WriteLine(reverseName);

            //Console.ReadKey();

            Application.Run(new PersonUI());
        }
    }
}
