using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRootExceptionHandling
{
    class MainDriver
    {
        static void Main(string[] args)
        {
            int number;
            try
            {
                Console.WriteLine("Enter the number");
                number = Convert.ToInt32(Console.ReadLine());
                if (number >= 0)
                    Console.WriteLine("Square root of the given number {0} is {1}", number, Math.Round(Math.Sqrt(number),3));
                else
                    throw new NotFiniteNumberException();
            }
            catch
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
            Console.ReadKey();
        }
    }
}
