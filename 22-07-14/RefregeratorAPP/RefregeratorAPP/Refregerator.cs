using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefregeratorAPP
{
    class Refregerator
    {
        private double maxWeight;
        private double totalWeight;       
        private  double currentWeight = 0;
        private double remainingWeight = 0;

        public double MaxWeight
        {
            get { return maxWeight; }
            set { maxWeight = value; }
        }

        public double TotalWeight
        {
            get { return totalWeight; }
            set { totalWeight = value; }
        }

        public double CurrentWeight
        {
            get { return currentWeight; }
           
        }

        public double RemainingWeight
        {
            get { return remainingWeight; }
            
        }

        public void AddItems(int noOfItems,double weight)
        {
            totalWeight = noOfItems * weight;
            if (currentWeight+totalWeight <= maxWeight)
            {
                currentWeight = totalWeight;
                remainingWeight = maxWeight - currentWeight;
            }

            else
            {
               throw new Exception("Overloaded..");

            }
            
        }
    }
}
