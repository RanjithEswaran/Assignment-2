using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorExample
{
    class Number
    {
        int Data;
        public Number(int Data)
        {
            this.Data = Data;
            Console.WriteLine("Object Created with data {0}",this.Data);
        }
         ~Number()
        {
            Console.WriteLine("Object destroyed in Destructor");
        }
    }
    class MainDriver
    {
        static void Main(string[] args)
        {
            int Data;
            { 
            Console.WriteLine("Enter Data");
            Data = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Creating Object in Main Function");
            Number test = new Number(Data);
            test = null;
        }
            
            Console.WriteLine("Thank you in main");
            Console.ReadKey();
        }
    }
}
