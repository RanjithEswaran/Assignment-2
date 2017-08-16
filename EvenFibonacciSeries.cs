using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciSeries
{
    class Program
    {
        void Fibonacci(int range)
        {
            int a = 0,b=1,c,sum=0;
            for(int i=2;i<range;i++)
            {
                c = a + b;
                a = b;
                b = c;
                if (c % 2 == 0)
                {
                    Console.WriteLine("{0} ", c);
                    sum += c;
                }
            }
            Console.WriteLine("The sum of even terms in Fibonacci series is {0}", sum);
        }
        static void Main(string[] args)
        {
            int Range;
            Console.WriteLine("Enter the Range");
            Range = Convert.ToInt16(Console.ReadLine());
            Program p = new Program();
            p.Fibonacci(Range);
            Console.ReadKey();
        }
    }
}
