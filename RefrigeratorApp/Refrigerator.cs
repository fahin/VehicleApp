using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorApp
{
    class Refrigerator
    {
        private double maxAmount;

        public double MaxAmount
        {
            get { return maxAmount; }
            set { maxAmount = value; }
        }
        private double totalAmount=0;

        public double TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }

        public void totalCalculation(double item, double weight)
        {
            double tempTotal = (item * weight);
            totalAmount += tempTotal;
        if (totalAmount >maxAmount)
        {
           // double tempTotal = (item * weight);
           //totalAmount += tempTotal;
           //if (totalAmount <= maxAmount)
           //{
             totalAmount = totalAmount- tempTotal;
           //}
        }
        }
       

                
                
        
        }

    }

