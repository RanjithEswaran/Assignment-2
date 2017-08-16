using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonViewTest
{
    interface IPerson
    {
        void getDescription();
    }
    class Student : IPerson
    {
        string Name;
        string EmailId;
        char Grade;
        public char getGrade()
        {
            return this.Grade;
        }
        public void getDescription()
        {
            char grade = getGrade();
            Console.WriteLine("Student's Grade is {0}", grade);
        }
        public Student(string Name, String EmailId, char Grade)
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
    class Lecturer : IPerson
    {
        string Name;
        string Subject;
        public Lecturer(string Name, string Subject)
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
            Console.WriteLine("The teacher {0} teaches {1}", Name, getSubject());
        }
    }
    class Employee : IPerson
    {
        string Department;
        public Employee(string Name, string Department)
        {
            this.Department = Department;
        }

        public string getDepartment()
        {
            return this.Department;
        }
        public void getDescription()
        {
            Console.WriteLine("The Employee works in {0} Department", getDepartment());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            string Choice;
            do {
                Console.WriteLine("1.Student\n2.Lecturer\n3.Employee");
                ch = Convert.ToInt16(Console.ReadLine());
                try
            {
                switch (ch)
                {
                    case 1:
                        string Name, EmailId, choice;
                        char Grade;
                        do
                        {
                            try
                            {
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
                            Console.WriteLine("Do you want to continue Adding Student ?Yes/No");
                            choice = Convert.ToString(Console.ReadLine());
                        } while (choice.Equals("Yes") || choice.Equals("yes") || choice.Equals("YES") || choice.Equals("Y") || choice.Equals("y"));
                        break;
                    case 2:
                            string Subject;
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
                            Console.WriteLine("Do you want to Continue adding Lecturer? Yes/No");
                            Choice = Convert.ToString(Console.ReadLine());
                        } while (Choice.Equals("Yes") || Choice.Equals("yes") ||
                        Choice.Equals("YES") || Choice.Equals("Y") || Choice.Equals("y"));
                        break;
                    case 3:
                        string Department;
                        do
                        {
                            try
                            {
                                Console.WriteLine("Enter the Employee Details");
                                Console.WriteLine();
                                Console.WriteLine("Enter the Name");
                                Name = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("Enter the department");
                                Department = Convert.ToString(Console.ReadLine());
                                Employee employee = new Employee(Name, Department);
                                Console.WriteLine();
                                Console.WriteLine("Details");
                                employee.getDescription();
                                Console.WriteLine();
                            }
                            catch
                            {
                                Console.WriteLine("Invalid Input");
                            }
                            Console.WriteLine("Do you want to Continue adding Employee? Yes/No");
                            Choice = Convert.ToString(Console.ReadLine());
                        } while (Choice.Equals("Yes") || Choice.Equals("yes") ||
                        Choice.Equals("YES") || Choice.Equals("Y") || Choice.Equals("y"));
                        break;
                    default:
                        Console.WriteLine("Thank You");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine("Do you want to Continue the Same Process? Yes/No");
            Choice = Convert.ToString(Console.ReadLine());
        } while (Choice.Equals("Yes") || Choice.Equals("yes") ||
                        Choice.Equals("YES") || Choice.Equals("Y") || Choice.Equals("y"));
            Console.ReadKey();
        }
    }
}
