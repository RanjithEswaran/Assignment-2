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
    class MainDriver
    {
        static void Main(string[] args)
        {
            string Name, Department,Choice;
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
                    Employee employee = new Employee(Name,Department);
                    Console.WriteLine();
                    Console.WriteLine("Details");
                    employee.getDescription();
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.WriteLine("Do you want to Continue? Yes/No");
                Choice = Convert.ToString(Console.ReadLine());
            } while (Choice.Equals("Yes") || Choice.Equals("yes") ||
            Choice.Equals("YES") || Choice.Equals("Y") || Choice.Equals("y"));
            Console.ReadKey();
        }
    }
}
