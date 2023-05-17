using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REVERSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            for(int i = 0; i < 5; i++)
            {
                number[i] = int.Parse(Console.ReadLine());

            }
            Array.Reverse(number);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}",number[i]);
            }

        }
    }
}
