using AccountDemoApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Account a = null;
            do
            {
                Console.WriteLine("******************************");
                Console.WriteLine("**** Accounts Application ****");
                Console.WriteLine("******************************");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Display Account Information");
                Console.WriteLine("3. Deposit Amount");
                Console.WriteLine("4. Withdraw Amount");
                Console.WriteLine("5.Available balance");
                Console.WriteLine("0. Quit");
                Console.WriteLine("Enter Choice :");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Account Id:");
                        int Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Name:");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Enter Opening Balance:");
                        decimal Balance = decimal.Parse(Console.ReadLine());
                        a = new Account();
                        a.CreateAccount(Id, Name, Balance);
                        break;
                    case 2:
                        if (a != null)
                            a.DisplayInfo();
                        else
                            Console.WriteLine("********* Open Account First *********\n");
                        break;
                    case 3:
                        if (a != null)
                        {
                            Console.WriteLine("enter amont to deposit");
                            decimal amount = decimal.Parse(Console.ReadLine());
                            a.Deposit(amount);
                        }
                        else
                            Console.WriteLine("********* Open Account First *********\n");
                        break;

                    case 4:
                        if (a != null)
                        {
                            Console.WriteLine("enter amont to withdraw");
                            decimal amount2 = decimal.Parse(Console.ReadLine());
                            a.withdraw(amount2);
                        }
                        else
                        {
                            Console.WriteLine("********* Open Account First *********\n");
                        }
                    break;
                case 5:
                        if (a != null)
                        {
                            Console.WriteLine("Availablr balance" + a.Balance);
                        }
                        break;
                         
                        
                case 0:
                    break;
                default:
                    Console.WriteLine("********* Wrong Choice *********\n");
                    break;
                }
            } 
            while (ch != 0);
            Console.WriteLine("********* Thanks for Using Banking Operations  *********\n");
         }
    }
}