using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle aRectangle = new Rectangle();
            Console.WriteLine(aRectangle.GetArea());
            Console.ReadKey();
        }
    }
}
