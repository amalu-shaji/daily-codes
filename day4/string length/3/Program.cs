// Write a program in C# Sharp to find the length of a string without using library function. Go to the editor


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            int l= 0;
            Console.WriteLine("enter the string");
                a = Console.ReadLine();
            foreach(char ch in a)
            {
                l= l+1;

            }
            Console.WriteLine("length is :" + l);
            Console.ReadKey();
        }
        
    }
}
