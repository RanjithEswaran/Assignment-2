using System;
namespace PrintMethod
{
    class Program
    {
        public void Print(int len)
        {
            for(int i=0;i< len;i++)
            Console.Write("*");
        }
        static void Main(string[] args)
        {
            int len;
            len = 20;
            Program obj = new Program();
            obj.Print(len);
            Console.ReadKey();
        }
    }
}
