using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerSwap
{
    class Integer
    {
        int number1;
        int number2;
        public Integer(int number1,int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }
        public void Swap(Integer object1)
        {
            int temp1=object1.number1, temp2=object1.number2;
             object1.number1 = this.number1;
             object1.number2 = this.number2;
            this.number1 = temp1;
            this.number2 = temp2;
         
        }
        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine("Number1 : {0}", this.number1);
            Console.WriteLine("Number2 : {0}", this.number2);
        }
    }
    class MainDriver
    {
        static void Main(string[] args)
        {
            int Number1, Number2;
            Console.WriteLine("Enter the details of object1");
            Console.WriteLine();
            Console.WriteLine("Enter the Number1");
            Number1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Number2");
            Number2 = Convert.ToInt16(Console.ReadLine());
            Integer integer1 = new Integer(Number1, Number2);
            Console.WriteLine("Enter the details of object2");
            Console.WriteLine();
            Console.WriteLine("Enter the Number1");
            Number1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Number2");
            Number2 = Convert.ToInt16(Console.ReadLine());
            Integer integer2 = new Integer(Number1, Number2);
            Console.WriteLine();
            Console.WriteLine("Details Before swapping");
            Console.WriteLine();
            Console.WriteLine("Object 1");
            integer1.Display();
            Console.WriteLine();
            Console.WriteLine("Object 2");
            integer2.Display();
            Console.WriteLine();
            Console.WriteLine("Detail After swapping");
            integer1.Swap(integer2);
            Console.WriteLine();
            Console.WriteLine("Object 1");
            integer1.Display();
            Console.WriteLine();
            Console.WriteLine("Object 2");
            integer2.Display();
            Console.ReadKey();
        }
    }
}
