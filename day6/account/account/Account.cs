using System;
using System.Runtime.InteropServices;

namespace AccountDemoApp
{
    class Account
    {
        public int Id;
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 15)
                {
                    throw new ApplicationException("Name is too big");
                    _name = value;
                }
            }
        }

        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public void CreateAccount(int id, string name, decimal balance)
        {
            Id = id;
            Name = name;
            _balance = balance;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Account Id :" + Id);
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Balance :" + Balance);
        }
        public void Deposit(decimal amount)
        {
            _balance += amount;
        }
        public void withdraw(decimal amount)
        {
            if(_balance<amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                _balance -= amount;
                
            }
            
        }




        
    }
}
    