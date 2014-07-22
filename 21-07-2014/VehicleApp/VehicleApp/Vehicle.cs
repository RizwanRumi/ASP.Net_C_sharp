using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Vehicle
    {
        public string name;
        public string reg;
        public double speed;
        //public double currentSpeed;
        public double speedEntry;
        public double max;
        public double min;
        public double average;

        public double GetSpeed(double entrySpeed)
        {
            if (entrySpeed == 0)
            {
                max = entrySpeed;
                min = entrySpeed;
            }

            else
            {
                if()
                {}
            }

        }
        public double GetMaxSpeed()
        {
            if (speedEntry > max)
                return max =  speedEntry;
            else
                return min = speedEntry;
            
            

        }

        public double GetMinSpeed()
        {
            if (speedEntry < min)
              return  min = speedEntry;
            else
              return max = speedEntry;
            

        }

       
    }

        

    }

