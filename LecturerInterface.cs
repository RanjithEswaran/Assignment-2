using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecturerInterface
{
    interface IPerson
    {
        void getDescription();
    }
    class Lecturer : IPerson
    {
        string Name;
        string Subject;
      public  Lecturer(string Name,string Subject)
        {
            this.Name = Name;
            this.Subject = Subject;
        }
        public string getSubject()
        {
            return this.Subject;
        }
        public void getDescription()
        {
            Console.WriteLine("The teacher {0} teaches {1}",Name,getSubject());
        }
    }
    class MainDriver
    {
        static void Main(string[] args)
        {
            string Name, Subject, Choice;
            do
            {
                try
                {
                    Console.WriteLine("Enter the Lecturer Details");
                    Console.WriteLine();
                    Console.WriteLine("Enter the Name");
                    Name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the subject");
                    Subject = Convert.ToString(Console.ReadLine());
                    Lecturer lecturer = new Lecturer(Name, Subject);
                    Console.WriteLine();
                    Console.WriteLine("Details");
                    lecturer.getDescription();
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.WriteLine("Do you want to Continue? Yes/No");
                Choice = Convert.ToString(Console.ReadLine());
            } while (Choice.Equals("Yes")|| Choice.Equals("yes")||
            Choice.Equals("YES")|| Choice.Equals("Y")|| Choice.Equals("y"));
            Console.ReadKey();
        }
    }
}
