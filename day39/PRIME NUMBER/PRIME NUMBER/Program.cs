using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIME_NUMBER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the desired max number to display prime number");
            int n = int.Parse(Console.ReadLine());
            bool isPrimenumber = true;
            Console.WriteLine("the prime number betwwen {0} and {1} is:", 2, n);
            for (int i = 2; i <= n; i++)
            {
                for (int j = 2; j <= n; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrimenumber = false;
                        break;
                    }
                }
                if (isPrimenumber)
                {
                    Console.WriteLine(i);
                }
                isPrimenumber = true;
            }
        }
    }
}
