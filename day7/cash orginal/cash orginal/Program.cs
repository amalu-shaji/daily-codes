using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cash_orginal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the amt:");
            int amt = int.Parse(Console.ReadLine());
            int x = amt/ 2000;
            amt = amt % 2000;
            Console.WriteLine("no of 2000 notes:" +x);
            int y = amt / 500;
            amt = amt % 500;
            Console.WriteLine("no of 500 notes:" + y);
            int z = amt / 200;
            amt = amt % 200;
            Console.WriteLine("no of 200 notes:" + z);
            int m = amt / 100;
            amt = amt % 100;
            Console.WriteLine("no of 100 notes:" + m);
            int n = amt / 50;
            amt = amt % 50;
            Console.WriteLine("no of 50 notes:" + n);
            int o = amt / 10;
            amt = amt % 10;
            Console.WriteLine("no of 10 notes:" + o);
            int p = amt / 5;
            amt = amt % 5;
            Console.WriteLine("no of 5 notes:" + p);
            int q = amt / 2;
            amt = amt % 2;
            Console.WriteLine("no of 2 notes:" + q);
              int r = amt / 1;
            amt = amt % 1;
            Console.WriteLine("no of 1 notes:" + q);
            Console.ReadKey();
        }

    }
}
