using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDesigns
{
    //Only Structure Design
    //No Main Function Asked in Question 
    struct Student
    {
        string name;
        int MarksObtained;
        struct DOB
        {
            int Day;
            int Month;
            int Year;

            DOB(int Day,int Month,int Year)
            {
                this.Day = Day;
                this.Month = Month;
                this.Year = Year;
            }
            
        }
        Student(string Name,int MarksObtained)
        {
            this.name = Name;
            this.MarksObtained = MarksObtained;
        }
    }
    struct MailingList
    {
        int DoorNumber;
        string StreetName;
        string Name;
        long PinCode;
        string City;
        MailingList(string Name,int DoorNumber,string StreetName,string City,long PinCode)
        {
            this.Name = Name;
            this.DoorNumber = DoorNumber;
            this.StreetName = StreetName;
            this.City = City;
            this.PinCode = PinCode;
        }

    }
    struct Book
    {
        string Title;
        string Author;
        int PublicationYear;
        double Cost;
        Book(string Title,string Author,int PublicationYear,double Cost)
        {
            this.Title = Title;
            this.Author = Author;
            this.PublicationYear = PublicationYear;
            this.Cost = Cost;
        }
    }
    struct Inventory
    {
        string ItemCode;
        string ItemName;
        double Cost;
        int Quantity;
        static int TotalItemsAvailable=0;
        Inventory(string ItemCode,string ItemName,int Quantity,double Cost)
        {
            this.ItemCode = ItemCode;
            this.ItemName = ItemName;
            this.Cost = Cost;
            this.Quantity = Quantity;
            TotalItemsAvailable++;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
