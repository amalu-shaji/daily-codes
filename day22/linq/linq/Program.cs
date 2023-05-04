using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 3, 4 };
            var num = from n in ar
                      where n % 2 == 0
                      select n;
            foreach (int n in ar)
            {
                Console.WriteLine(n);
            }
        }
    }
}
