using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("enter the age :");
            age = int.Parse(Console.ReadLine());
            int result = voting(age);
            if (result == 1)
            {
                Console.WriteLine("elligible to vote");

            }
            else
            {
                Console.WriteLine("Not elligible to vote");
            }
            Console.ReadKey();

        }
        static int voting(int age)
        {
            if (age >= 18)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
