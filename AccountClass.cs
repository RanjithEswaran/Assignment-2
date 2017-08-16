using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
    class BankAccount
    {
        string HolderName;
        string AccountNumber;
        string TypeOfAccount;
        double Balance;
        public BankAccount(string HolderName,string AccountNumber,string TypeOfAccount,double Balance)
        {
            this.HolderName = HolderName;
            this.AccountNumber = AccountNumber;
            this.TypeOfAccount = TypeOfAccount;
            this.Balance = Balance;
        }
        public void Display()
        {
            Console.WriteLine("Account Details");
            Console.WriteLine("Holder Name : {0}", HolderName);
            Console.WriteLine("Account Number : {0}", AccountNumber);
            Console.WriteLine("Type Of Account : {0}", TypeOfAccount);
            Console.WriteLine("Balance : {0}", Balance);
        }
        public void Deposit(double Amount)
        {
            this.Balance += Amount;
            Console.WriteLine("Amount Deposited Successfully");
        }
        public void Withdraw(double Amount)
        {
            if (Amount < Balance - 500)
            {
                Balance -= Amount;
                Console.WriteLine("Amount withdrawn successfully");
            }
            else
                Console.WriteLine("Minimum Balance is must.So cannot withdraw the given amount");
        }
    }
    class MainDriver
    {
        static void Main(string[] args)
        {
            string Name, AccountNumber, TypeOfAccount;
            double Amount;
            string Choice;
            int check = 1;
            Console.WriteLine("Enter the Account Holder Name");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Account Number");
            AccountNumber = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Type Of Account? CA/Savings");
            TypeOfAccount = Convert.ToString(Console.ReadLine());
            do
            {
                Console.WriteLine("Enter the Amount Greater than 500 to deposit ");
                Amount = Convert.ToDouble(Console.ReadLine());
                if (Amount >= 500)
                    check = 0;
            } while (check == 1);
            BankAccount account = new BankAccount(Name, AccountNumber, TypeOfAccount, Amount);
            Console.WriteLine("\nWelcome\n");
            do
            {
                try
                {
                    Console.WriteLine("1.Deposit\n2.Withdraw\n3.Display\n4.Exit");
                    int choice;
                    choice = Convert.ToInt16(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the amount to deposit");
                            Amount = Convert.ToDouble(Console.ReadLine());
                            account.Deposit(Amount);
                            break;
                        case 2:
                            Console.WriteLine("Enter the amount to withdraw");
                            Amount = Convert.ToDouble(Console.ReadLine());
                            account.Withdraw(Amount);
                            break;
                        case 3:
                            Console.WriteLine();
                            account.Display();
                            break;
                        default:
                            Console.WriteLine("Thank You for Banking");
                            break;
                    }

                }
                catch
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.WriteLine("Do you want to continue ? Yes/No");
                Choice = Convert.ToString(Console.ReadLine());
            } while (Choice.Equals("Yes")|| Choice.Equals("yes")|| Choice.Equals("Y")|| Choice.Equals("y")|| Choice.Equals("YES"));
            Console.WriteLine("Thank You for Banking");
            Console.ReadKey();
        }
    }
}
