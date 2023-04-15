// Write a C# Sharp program to get the day of the week for a specified date.The day of the week for 7/11/2016 is Monday. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_time2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2016, 11, 7);
            Console.WriteLine("The day of the week for {0:d} is {1}", dt, dt.DayOfWeek);
            Console.ReadKey();

        }
    }
}
   