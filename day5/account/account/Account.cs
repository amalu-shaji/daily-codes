using System;

namespace AccountDemoApp
{
    class Account
    {
        public int Id;
        public string Name;
        public decimal Balance;

        public void CreateAccount(int id, string name, decimal balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Account Id :" + Id);
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Balance :" + Balance);
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void withdraw(decimal amount)
        {
            if(Balance<amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Availble balance is:" + Balance);
            }
            
        }




        
    }
}
    