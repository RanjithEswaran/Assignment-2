using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestOfThreeNumbers
{
    class Largest
    {
        int LargestNum(int num1,int num2,int num3)
        {
            if (num1 > num2 && num1 > num3)
                return num1;
            else if (num2 > num3)
                return num2;
            else
                return num3;
        }
        static void Main(string[] args)
        {
            int ch=1, num1, num2, num3;
            try
            {
                do
                {
                    Console.WriteLine("Enter Number 1");
                    num1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter Number 2");
                    num2 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter Number 3");
                    num3 = Convert.ToInt16(Console.ReadLine());
                    Largest largest = new Largest();
                    int num=largest.LargestNum(num1, num2, num3);
                    Console.WriteLine("Largest Number is {0}", num);
                    Console.WriteLine("Do you Want to continue? Yes/No");
                    string s = Convert.ToString(Console.ReadLine());
                    if (s.Equals("yes") || s.Equals("Yes"))
                        ch = 1;
                    else
                        ch = 0;
                } while (ch==1);

            }
            catch
            {
                Console.WriteLine("Invalid Data");
            }
            Console.ReadKey();
        }
    }
}
