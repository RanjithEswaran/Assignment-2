using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountInheritance
{
  
    class Account
    {
      protected  string Name;
      protected  string TypeOfAccount;
      protected  string AccountNumber;
      protected  double Balance;
        public Account(string Name,String TypeOfAccount,string AccountNumber)
        {
            this.Name = Name;
            this.TypeOfAccount = TypeOfAccount;
            this.AccountNumber = AccountNumber;
            Balance = 0;
        }
        public virtual void Deposit(double amount,double interest)
        {
            Balance += amount+(amount*interest/100);
        }
        public virtual void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public virtual void Display()
        {
            Console.WriteLine("Account Number : {0}", AccountNumber);
            Console.WriteLine("Name :{0}", Name);
            Console.WriteLine("Type of Account : {0}", TypeOfAccount);
            Console.WriteLine("Balance : {0}", Balance);
        }
    }
    class Savings : Account
    {
        double interestPercent; 
        public Savings(string Name, String TypeOfAccount, string AccountNumber,double interestPercent)
            :base(Name, TypeOfAccount, AccountNumber)
        {
            this.interestPercent = interestPercent;
        }
        public override void Deposit(double amount,double interest)
        {
            base.Deposit(amount,interest);
            Console.WriteLine("Amount Deposited");
        }
        public override void Withdraw(double amount)
        {
            if (base.Balance > amount) { 
            base.Withdraw(amount);
            Console.WriteLine("Amount Withdrawn");
        }
        else
        Console.WriteLine("Low balance cannot withdraw");
        }
        public override void Display()
        {
            base.Display();
        }
    }
    class Current : Account
    {
        double minimumBalance;
        string ChequeBookNumber;
        public Current(string Name, String TypeOfAccount, string AccountNumber, double minimumBalance,string ChequeBookNumber)
            :base(Name, TypeOfAccount, AccountNumber)
        {
            this.minimumBalance = minimumBalance;
            this.ChequeBookNumber= ChequeBookNumber;
        }
        public override void Deposit(double amount,double Interest)
        {
            base.Deposit(amount,0);
            Console.WriteLine("Amount Deposited");
        }
        public override void Withdraw(double amount)
        {
            if (base.Balance > amount)
            {
                base.Withdraw(amount);
                Console.WriteLine("Amount Withdrawn");
                if (base.Balance < minimumBalance)
                    base.Balance -= 30;
            }
            else
                Console.WriteLine("Low balance cannot withdraw");
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Cheque book number {0}", ChequeBookNumber);
        }

    }
    class MainDriver
    {
        static void Main(string[] args)
        {
            string name, chequeBookNumber="1009",choice;
            string AccountNumber="1112334";
            double amount,interestPercent;
   
            Console.WriteLine("Enter your name");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your account number");
            AccountNumber = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your Interest Percent");
            interestPercent = Convert.ToDouble(Console.ReadLine());
            Savings s = new Savings(name, "SA", AccountNumber, interestPercent);
            Current c = new Current(name, "CA", AccountNumber, 500, chequeBookNumber);

            do
            {
                Console.WriteLine("1.Deposit Savings Account\n2.Deposit current Account\n3.Withdraw from savings account\n4.Withdraw from Current Account\n5.Display Account Details");
                int ch = Convert.ToInt16(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                         Console.WriteLine("Enter Amount to Deposit");
                         amount = Convert.ToDouble(Console.ReadLine());
                        s.Deposit(amount,interestPercent);
                         break;
                    case 2:
                         Console.WriteLine("Enter Amount to Deposit");
                         amount = Convert.ToDouble(Console.ReadLine());
                        c.Deposit(amount,0);
                         break;
                    case 3:
                        Console.WriteLine("Enter Amount to withdraw");
                        amount = Convert.ToDouble(Console.ReadLine());
                        s.Withdraw(amount); 
                        break;
                    case 4:
                        Console.WriteLine("Enter Amount to withdraw");
                        amount = Convert.ToDouble(Console.ReadLine());
                        c.Withdraw(amount);
                        break;
                    case 5:
                        s.Display();
                        c.Display();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.WriteLine("Do you want to continue ? Yes/No");
                choice = Convert.ToString(Console.ReadLine());
            } while (choice.Equals("Yes")|| choice.Equals("yes")|| choice.Equals("YES")|| 
            choice.Equals("Y")|| choice.Equals("y"));
            Console.ReadKey();
        }
    }
}
