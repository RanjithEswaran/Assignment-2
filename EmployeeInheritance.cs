using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInheritance
{
    class Person
    {
        int Age;
        string Name;
        string Gender; 
        public Person(int Age,string Name,string Gender)
        {
            this.Age = Age;
            this.Name = Name;
            this.Gender = Gender;
        }
        public virtual void Display()
        {
            Console.WriteLine("Employee Details :");
            Console.WriteLine("Name : {0}", Name);
            Console.WriteLine("Age : {0}", Age);
            Console.WriteLine("Gender: {0}", Gender);
        }
    }
    class Employee : Person
    {
        string EmployeeCode;
        public Employee(int Age, string Name, string Gender,string EmployeeCode):base(Age,Name,Gender)
        {
            this.EmployeeCode = EmployeeCode;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Employee Code : {0}", EmployeeCode);
        }
    }
    class Specialist : Employee
    {
        string SpecialistIn;
        public Specialist(int Age, string Name, string Gender, string EmployeeCode,
            string SpecialistIn):base(Age, Name, Gender, EmployeeCode)
        {
            this.SpecialistIn = SpecialistIn;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Specialist in : {0}", SpecialistIn);
            Console.WriteLine();
        }
    }
    class MainDriver
    {
        static void Main(string[] args)
        {
            int num=3,i=0;
            string Name, EmployeeCode, Gender, SpecialistIn;
            int age;
            try {
                Employee[] employee = new Employee[3];
                do
                {
                    Console.WriteLine("Enter the details of Employee {0}", i + 1);
                    Console.WriteLine("Enter the name");
                    Name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the Gender");
                    Gender = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the EmployeeCode");
                    EmployeeCode = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the age");
                    age = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine();
                    employee[i] = new Employee(age, Name, Gender, EmployeeCode);
                    i++;
                } while (i < 3);
                for (i = 0; i < 3; i++)
                {
                    Console.WriteLine("Details of Employee {0}", i + 1);
                    employee[i].Display();
                    Console.WriteLine();
                }
                i = 0;
                Specialist[] specialist = new Specialist[3];
                do
                {
                    Console.WriteLine("Enter the details of Specialist {0}", i + 1);
                    Console.WriteLine("Enter the name");
                    Name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the Gender");
                    Gender = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the EmployeeCode");
                    EmployeeCode = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the age");
                    age = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter the Specialisation");
                    SpecialistIn = Convert.ToString(Console.ReadLine());
                    specialist[i] = new Specialist(age, Name, Gender, EmployeeCode, SpecialistIn);
                    i++;
                } while (i < 3);
                for (i = 0; i < 3; i++)
                {
                    Console.WriteLine("Details of Specialist {0}", i + 1);
                    specialist[i].Display();
                    Console.WriteLine();
                }
            }
            catch
            {

                Console.WriteLine("Invalid Data");
            }
            Console.ReadKey();

        }
    }
}
