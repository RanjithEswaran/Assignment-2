using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferenceException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a null refernce");
            try {
                Object obj = null;
                obj.GetHashCode();
            }
            catch
            {
                Console.WriteLine("Caught Null Object refernce Exception");
            }
            Console.ReadKey();
        }
    }
}
