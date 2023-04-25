using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEPTION3
{
    class Customer
    {
        string name; int accno; int balance;

        public Customer(string n, int a, int b)

        {

            name = n;

            accno = a;

            balance = b;

        }

        public void withdraw(int amt)

        {

            if (balance - amt <= 100)

                throw new BankException(accno, balance);

            balance -= amt;

        }

        public int getbalance()

        {

            return balance;

        }

    }
}