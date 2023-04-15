using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR_LOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum = 0;
            Console.WriteLine("display n terms and there sum");

            Console.WriteLine("input values");
            n = int.Parse(Console.ReadLine());
            for(i = 1; i <= n; i++)
            {
                sum=sum+i;
              
                
            }
            Console.WriteLine("sum is:" + sum);
            Console.ReadKey();


        }
    }
}
