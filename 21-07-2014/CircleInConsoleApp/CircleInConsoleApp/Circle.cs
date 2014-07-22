using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleInConsoleApp
{
    class Circle
    {
       // const double PI = 3.1415629;
         
        public double redious;   
         public double peremeter;
         public double diameter;
         public double area;

        public double Diameter()
         {
            return 2*redious;
         }
        public double Perimeter()
        {
            return Math.PI * Diameter();
        }
        public double Area()
        {
            return PI * redious * redious;
        }
    }
}
