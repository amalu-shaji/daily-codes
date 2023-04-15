//program to find absolute difference
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absolute_org
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the number");
            n = int.Parse(Console.ReadLine());
            int result=absolutediff(n);
            Console.WriteLine("Absolute difference is result :" + result);
            Console.ReadKey(); 
        }
        static int absolutediff(int n)
        {
            if(n  > 51)
            {
                int res = (n - 51) * 3;
                return res;
            }
            else 
            {
                int res1 = n - 51;
                return res1;
            }
        }
    }
}
