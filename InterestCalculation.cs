using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculation
{
    class Interest
    {
        void CalcualteInterest(int years,double amount,double percent)
        {
            Console.WriteLine("Payment Details");
            Console.WriteLine("Interest {0}", amount * years * percent / 100);
            Console.WriteLine("Principle {0}", amount);
            Console.WriteLine("Number Of Years {0}", years);
            Console.WriteLine("Amount to be paid {0}", (amount * years * percent / 100)+amount);
        }
        static void Main(string[] args)
        {
            int years;
            double percent, amount;
            try {
                Console.WriteLine("Enter the Principal amount");
                amount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the number of years");
                years = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the interest percentage");
                percent = Convert.ToDouble(Console.ReadLine());
                Interest interest = new Interest();
                interest.CalcualteInterest(years, amount, percent);
            }
            catch
            {
                Console.WriteLine("Invalid data");
            }
            Console.ReadKey();

        }
    }
}
