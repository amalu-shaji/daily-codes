using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "10001,meyayyapan@gmail.com";
            string[] entries = input.Split(',');
            foreach (string entry in entries)
            {
                Console.WriteLine(entry);
                Console.ReadKey();

            }
        }
    }
}
