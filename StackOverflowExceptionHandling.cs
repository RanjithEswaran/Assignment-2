using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowExceptionHandling
{
    class Program
    {
        private static int Call()
        {
            
            return Call();
        }
        static void Main(string[] args)
        {
            try {
                int num = Call();
            }
            catch(StackOverflowException e)
            {
                Console.WriteLine("Caught {0}", e);
            }
            Console.ReadKey();
        }
    }
}
