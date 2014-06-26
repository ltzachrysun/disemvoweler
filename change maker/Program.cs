using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HPMoneyChange
{
    class Program
    {
        static void Main(string[] args)
        {
         


        }

        static void ChangeMaker(double amount)
        {
            int quarter = 0;
            int dime = 0;
            int nikle = 0;
            int penny = 0;

            while (amount >= 0.25)
            {
                amount -= 0.25;
            }

            while (amount >= 0.10)
            {
                amount -= 0.10;
            }

            while (amount >= 0.05)
            {
                amount -= 0.05;
            }

            while (amount >= 0.01)
            {
                amount -= 0.01;
            }
        }
    }
}
