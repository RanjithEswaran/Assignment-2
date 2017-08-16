using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCarVehicle
{
    class Vehicle
    {
        protected int noOfWheels;
       public Vehicle(int noOfWheels)
        {
            this.noOfWheels = noOfWheels;
        }
        public void Display()
        {
            Console.WriteLine("Vehicle Details\nNo Of Wheels {0}", noOfWheels);
        }
    }
    class Car : Vehicle
    {
        string registrationNumber;
       public Car(string registrationNumber,int NoOfWheels):base(NoOfWheels)
        {
            this.registrationNumber = registrationNumber;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("Registration Number {0}", registrationNumber);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(NoOfWheels:4,registrationNumber: "TN 41 R 1936");
            car.Display();
            Console.ReadKey();
        }
    }
}
