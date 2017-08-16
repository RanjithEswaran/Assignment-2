using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackObjects
{
    class Test
    {
        static int Count = 0;
        int data;
        public Test(int data)
        {
            this.data = data;
            Count++;
        }
        public void GetObjectCount()
        {
            Console.WriteLine("Number of objects created till now is {0}", Count);
        }
    }
    class MainDriver
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the number of objects you want to create");
            number = Convert.ToInt16(Console.ReadLine());
            int i=0;
            try {
                while (i < number)
                {
                    int data;
                    Console.WriteLine("Enter the data");
                    data = Convert.ToInt16(Console.ReadLine());
                    Test test = new Test(data);
                    Console.WriteLine("Number of objects created till now is");
                    test.GetObjectCount();
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
    }
}
