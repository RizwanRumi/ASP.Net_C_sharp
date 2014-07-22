using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleInConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle aCircle = new Circle();
            
            aCircle.redious = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Diameter : " + aCircle.Diameter());
            Console.WriteLine("Perimeter : " + aCircle.Perimeter());
            Console.WriteLine("Area : " + aCircle.Area());

            Console.ReadLine();

            
        }
    }
}
