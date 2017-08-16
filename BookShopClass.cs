using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopClass
{
    class Books{
        string Author;
        string Title;
        string Publisher;
        string Position;
        double Prize;
        int Quantity;
        public Books(string Title,string Author,string Publisher,string Position,double Prize,int Quantity )
        {
            this.Title = Title;
            this.Author = Author;
            this.Publisher = Publisher;
            this.Position = Position;
            this.Prize = Prize;
            this.Quantity = Quantity;
        }
        public void DisplayAllBooks(Books[] obj,int TotalNoOfBooks)
        {
            Console.WriteLine("Books in the Shop");
            int i = 0;
            for(i=0;i<TotalNoOfBooks;i++)
            {
                Console.WriteLine("Book {0}", i + 1);
                Console.WriteLine("Title {0}", obj[i].Title);
                Console.WriteLine("Author {0}", obj[i].Author);
                Console.WriteLine("Publisher {0}", obj[i].Publisher);
                Console.WriteLine("Position {0}", obj[i].Position);
                Console.WriteLine("Prize {0}", obj[i].Prize);
                Console.WriteLine("Quantity {0}", obj[i].Quantity);
                Console.WriteLine();
            }

        }
        public void SearchAndBuy(string Title,int len,Books[] obj)
        {

            for(int i=0;i< len; i++)
            {
                if(Title.Equals(obj[i].Title))
                {
                    Console.WriteLine("Book found");
                    Console.WriteLine("Enter the Quantity");
                    int quantity = Convert.ToInt16(Console.ReadLine());
                    if (quantity <= obj[i].Quantity)
                    {
                        Console.WriteLine("Book issued successfully Pay Rs {0:00.00} ",obj[i].Prize*quantity);
                        obj[i].Quantity -= quantity;
                        if (obj[i].Quantity == 0)
                            obj[i].Title = "";
                    }
                    else
                        Console.WriteLine("Quantity insufficient");

                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfBooks,Quantity;
            string Title, Author, Publisher, Position,Choice;
            double Prize;
            try
            {
                Console.WriteLine("Enter the number of books");
                NumberOfBooks = Convert.ToInt16(Console.ReadLine());
                Books[] book = new Books[NumberOfBooks];
                for(int i=0;i< NumberOfBooks;i++)
                {
                    
                    Console.WriteLine("Enter the Title");
                    Title = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the Author");
                    Author = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the Publisher");
                    Publisher = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the Position");
                    Position = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the Quantity");
                    Quantity = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter the Prize");
                    Prize = Convert.ToDouble(Console.ReadLine());
                    book[i] = new Books(Title, Author, Publisher, Position, Prize, Quantity);
                    Console.WriteLine();
                }
                book[0].DisplayAllBooks(book, NumberOfBooks);
                do
                {
                    int choose;
                    Console.WriteLine("1.Buy\n2.List the Books");
                    choose = Convert.ToInt16(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            Console.WriteLine("Enter the title of the book to buy");
                            Title = Convert.ToString(Console.ReadLine());
                            book[0].SearchAndBuy(Title, NumberOfBooks, book);
                            break;
                        case 2:
                            book[0].DisplayAllBooks(book, NumberOfBooks);
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;


                    }
                    Console.WriteLine("Do you want to continue ? Yes/No");
                    Choice = Convert.ToString(Console.ReadLine());
                } while (Choice.Equals("Yes") || Choice.Equals("yes") || Choice.Equals("YES") || Choice.Equals("Y") || Choice.Equals("y"));

            }
            catch
            {
                Console.WriteLine("Invalid Data");
            }
            Console.ReadKey();
        }
    }
}
