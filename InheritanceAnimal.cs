using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    class Animal
    {
        string Name;
        int age;
      public  Animal(string Name,int age)
        {
            this.Name = Name;
            this.age = age;
        }
       public virtual void Display()
        {
            Console.WriteLine("Animal Details :");
            Console.WriteLine("Name : {0}", Name);
            Console.WriteLine("Age : {0}", age);
        }
    }
    class Dog : Animal
    {
        string Breed;
      public  Dog(string name,int age,string breed) : base(name, age)
        {
            this.Breed = breed;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("My breed is {0}", Breed);
            Console.WriteLine("I bark");
        }
    }
    class Cat : Animal
    {
        string Breed;
      public  Cat(string name, int age, string breed) : base(name, age)
        {
            this.Breed = breed;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("My breed is {0}", Breed);
            Console.WriteLine("I eat rats");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            string name, breed;
            int age;
            try
            {
                do
                {
                    Console.WriteLine("Enter the Cat Details");
                    Console.WriteLine("Enter the name");
                    name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the age");
                    age = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter the breed");
                    breed = Convert.ToString(Console.ReadLine());
                    Cat cat = new Cat(name, age, breed);
                    Console.WriteLine("Enter the Dog Details");
                    Console.WriteLine("Enter the name");
                    name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the age");
                    age = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter the breed");
                    breed = Convert.ToString(Console.ReadLine());
                    Dog dog = new Dog(name, age, breed);
                    cat.Display();
                    Console.WriteLine();
                    dog.Display();
                    Console.WriteLine("Do you want to continue ?Yes/No");
                    choice = Convert.ToString(Console.ReadLine());
                } while (choice.Equals("Yes") || choice.Equals("yes") || choice.Equals("YES") || choice.Equals("Y") || choice.Equals("y"));

            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
    }
}
