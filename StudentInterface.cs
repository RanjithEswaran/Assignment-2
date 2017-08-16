using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInterface
{
    interface IPerson
    {
      char getGrade();
        void getDescription();
    }
   class Student : IPerson
    {
        string Name;
        string EmailId;
        char Grade;
      public  char getGrade()
        {
            return this.Grade;
        }
      public  void getDescription()
        {
            char grade =getGrade();
            Console.WriteLine("Student's Grade is {0}",grade);
        }
        public Student(string Name,String EmailId,char Grade)
        {
            this.Name = Name;
            this.EmailId = EmailId;
            this.Grade = Grade;
        }
      public void Display()
        {
            Console.WriteLine("Student Details");
            Console.WriteLine("Name : {0}", this.Name);
            Console.WriteLine("EmaildId :{0}", this.EmailId);
        }
    }
    class MainDriver
    {
       public static void Main()
        {
            string Name, EmailId,choice;
            char Grade;
            do
            {
                try {
                    Console.WriteLine("Enter the student details");
                    Console.WriteLine("Enter the name");
                    Name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the emailId");
                    EmailId = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the grade");
                    Grade = Convert.ToChar(Console.ReadLine());
                    Student s = new Student(Name, EmailId, Grade);
                    Console.WriteLine();
                    s.Display();
                    s.getDescription();
                   
                }
                catch
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.WriteLine("Do you want to continue ?Yes/No");
                choice = Convert.ToString(Console.ReadLine());
            } while (choice.Equals("Yes")|| choice.Equals("yes")|| choice.Equals("YES")|| choice.Equals("Y")|| choice.Equals("y"));
            Console.ReadKey();
        }
    }
}
