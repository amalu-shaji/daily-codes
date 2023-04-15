using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter the first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            b = int.Parse(Console.ReadLine());
            int result = sumofintegers(a, b);
            Console.WriteLine("sum of two given values:" +result);
            Console.ReadKey();
        }
        static int sumofintegers(int a, int b)
        {  
            int sum = 0;
            if( a == b )
            {
                sum = (a + b) * 3;
                return sum;
            }
            else
            {
                sum = a + b;
                return sum;
             }
          }
     }
}
