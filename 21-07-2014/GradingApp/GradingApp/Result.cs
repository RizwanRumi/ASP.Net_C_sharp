using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingApp
{
    class Result
    {
        public double physics;
        public double chemistry;
        public double math;
        public double average;
        public double total;
        public double result;

        public double GetResult()
        {
            total = physics + chemistry + math;
            average = total/3;
            return average;
        }
    }
}
