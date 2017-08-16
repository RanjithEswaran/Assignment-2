using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class Prime
    {
        Boolean CheckPrimeNumber(int num)
        {
            int i;
            if (num == 2)
                return true;
            for(i=2;i<Math.Sqrt(num);i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            try {
                int num = Convert.ToInt16(Console.ReadLine());
                Prime prime = new Prime();
                if (num == 1)
                    Console.WriteLine("Neither prime nor composite");
                else
                {
                    if (prime.CheckPrimeNumber(num))
                        Console.WriteLine("Prime Number");
                    else
                        Console.WriteLine("Not a Prime Number");
                }
            }
            catch
            {
                Console.WriteLine("Invalid data");
            }
            Console.ReadKey();
        }
    }
}
