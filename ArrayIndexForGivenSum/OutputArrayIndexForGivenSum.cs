using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfPairSum
{
    class Program
    {
        public static IEnumerable<Tuple<int,int>> FindIndex(List<int> list,int size,int sum)
        {
            List<Tuple<int,int>> answer=new List<Tuple<int, int>>();
            for(int i=0;i<size-1;i++)
            {
                for(int j=i+i;j<size;j++)
                {
                    if(list[i]+list[j]==sum)
                        answer.Add( Tuple.Create(i, j));
                }
            }
            foreach (var Element in answer)
                yield return Element;    
        }
        static void Main(string[] args)
        {
            string choice;
            List<int> list = new List<int>();
            try
            {
                do
                {
                    Console.WriteLine("Enter the number of elements in the list");
                    int size = Convert.ToInt16(Console.ReadLine());
                    for(int i=0;i< size;i++)
                    {
                        Console.WriteLine("Enter the element to insert");
                        list.Add(Convert.ToInt16(Console.ReadLine()));
                    }
                    Console.WriteLine();
                    Console.WriteLine("Enter the sum which must be equal to the sum of any two elements in the list");
                    int sum = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine();
                    var TupleList= Program.FindIndex(list, size, sum);
                    foreach (var Answer in TupleList)
                        Console.WriteLine(Answer);
                  /*int index1 = t.Item1;
                    int index2 = t.Item2;
                    if (index1 == -1)
                        Console.WriteLine("No two elements in the list sum to the given sum {0}", sum);
                    else
                        Console.WriteLine("The elements at the index {0} and {1} sum up to a value of {2} in the given list", index1, index2, sum);
                    Console.WriteLine();*/
                    Console.WriteLine("Do you want to continue ? Yes/No");
                    choice = Convert.ToString(Console.ReadLine());
                } while (choice.Equals("Yes") || choice.Equals("YES") || choice.Equals("yes") ||
                choice.Equals("Y")|| choice.Equals("y"));
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadLine();
        }
    }
}
