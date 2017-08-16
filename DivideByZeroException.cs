using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByZeroException
{
    class MainDriver
    {
        static void Main(string[] args)
        {
            try {
                double divident, divisor;
                Console.WriteLine("Enter the divident");
                divident = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the divisor");
                divisor = Convert.ToDouble(Console.ReadLine());
                if (divisor != 0)
                    Console.WriteLine("The result of division is {0} ", Math.Round(divident / divisor, 3));
                else
                    throw new Exception();
            }
            catch
            {
                Console.WriteLine("Cannot divide a number by zero");
            }
            Console.ReadKey();
        }
    }
}
