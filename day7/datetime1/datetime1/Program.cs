//Write a C# Sharp program to extract the Date property and display the DateTime value in the formatted output.
//Complete date: 6 / 8 / 2016 11:49:00 AM
//Short Date: 6 / 8 / 2016
//Display date using 24 - hour clock format:                                         
//6 / 8 / 2016 12:00 AM
//06/08/2016 00:00

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2016, 8, 6, 11, 49, 0);
            Console.WriteLine("complete date:"+dt1.ToString());
           // Console.ReadKey();
            // Get date-only portion of date, without its time.
            DateTime dateOnly = dt1.Date;
            Console.WriteLine("Short Date: " + dateOnly.ToString("d"));

            Console.WriteLine("Display date using 24-hour clock format:");

            Console.WriteLine(dateOnly.ToString("g"));
            Console.WriteLine(dateOnly.ToString("MM/dd/yyyy HH:mm"));
            Console.ReadKey();
        }
    }

}