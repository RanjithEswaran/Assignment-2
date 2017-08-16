using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleOf3Or5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Range;
            long sum =0;
            Console.WriteLine("Enter the range");
            Range = Convert.ToInt16(Console.ReadLine());
            for(int i=1;i<=Range;i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    sum += i;
                else if (i % 3 == 0)
                    sum += i;
                else if (i % 5 == 0)
                    sum += i;
            }
            Console.WriteLine("The sum of multiples of 3 and 5 within the given range is {0}", sum);
            Console.ReadKey();
        }
    }
}
