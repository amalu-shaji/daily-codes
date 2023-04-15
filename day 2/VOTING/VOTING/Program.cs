using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOTING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("enter the age");
            age = int.Parse(Console.ReadLine()); 
            if( age >= 18 )
            {
                Console.WriteLine(" elligible to vote");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Not elligible");
                    Console.ReadKey();
                  
            }
            
        }
    }
}
