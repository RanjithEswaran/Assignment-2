using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    class Sorting
    {
        void sort(int[] arr,int len)
        {
            Console.WriteLine("Ascending 1\nDescending 2");
            try {
                int ch = Convert.ToInt16(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        for (int i = 0; i < len - 1; i++)
                        {
                            for (int j = i + 1; j < len; j++)
                            {
                                if (arr[i] > arr[j])
                                {
                                    int t = arr[i];
                                    arr[i] = arr[j];
                                    arr[j] = t;
                                }
                            }
                        }

                        break;
                    case 2:
                        for (int i = 0; i < len - 1; i++)
                        {
                            for (int j = i + 1; j < len; j++)
                            {
                                if (arr[i] < arr[j])
                                {
                                    int t = arr[i];
                                    arr[i] = arr[j];
                                    arr[j] = t;
                                }
                            }
                        }

                        break;

                }
                Console.WriteLine("Sorted array is");
                for (int i = 0; i < len; i++)
                    Console.WriteLine(arr[i]);
            }
            catch
            {
                Console.WriteLine("Invalid data");
            }
        }
        static void Main(string[] args)
        {
            Sorting sorting = new Sorting();
            int len;
            try
            {
                Console.WriteLine("Enter the number of elements in the array");
                len = Convert.ToInt16(Console.ReadLine());
                int[] arr = new int[len];
                Console.WriteLine("Enter the array elements");
                for(int i=0;i< len;i++)
                {
                    arr[i] = Convert.ToInt16(Console.ReadLine());
                }
                sorting.sort(arr, len);
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Invalid data");
                Console.ReadKey();
            }
        }
    }
}
