using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateOfBirth
{
    public struct DOB
    {
        public int Day;
        public int Month;
        public int Year;
        public DOB(int Day, int Month, int Year)
        {
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
        }
    }
    class Program
    {
        public int ValidateDate(int day, int Month, int Year)
        {
            if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
            {
                if (day >= 1 && day <= 31)
                    return 1;
                else
                    return 0;
            }
            else if (Month == 2)
            {
                int flag = 0;
                if (Year % 4 == 0)
                {
                    if (Year % 100 == 0)
                    {
                        if (Year % 400 == 0)
                            flag = 1;
                        else
                            flag = 0;
                    }
                    else
                        flag = 1;
                }
                else
                    flag = 0;
                if (flag == 0)
                {

                    if (day >= 1 && day <= 28)
                        return 1;
                    else
                        return 0;
                }
                else
                {
                    if (day >= 1 && day <= 29)
                        return 1;
                    else
                        return 0;
                }
            }
            else
            {
                if (day >= 1 && day <= 30)
                    return 1;
                else
                    return 0;
            }
        }

        static void Main(string[] args)
        {
            int Day, Month, Year,check=0;
            try
            {
                do
                {
                    Console.WriteLine("Enter your Valid Date of Birth");
                    Console.WriteLine();
                    Console.WriteLine("Enter the Day");
                    Day = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter the Month");
                    Month = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter the Year");
                    Year = Convert.ToInt16(Console.ReadLine());
                    Program program = new Program();
                    check = program.ValidateDate(Day, Month, Year);
                } while (check != 1);
                DOB dob = new DOB(Day, Month, Year);
                Console.WriteLine();
                Console.WriteLine("Your Date Of Birth is {0:00}/{1:00}/{2}", dob.Day, dob.Month, dob.Year);
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Invalid Data");
            }
        }
    }
}
