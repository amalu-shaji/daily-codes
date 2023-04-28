using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add("maharashtra  ", "mumbai");
            s.Add("karnataka    ", "bangalore");
            s.Add("andrapradesh  ", "hyderabad");
            s.Add("tamilnadu     ", "chennai");
            s.Add("bihar         ", "patna");
            s.Add("rajasthan      ", "jaipur");
            Console.WriteLine("elements in the sorted list:");
            foreach (var item in s.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in s.Values)
            {
                Console.WriteLine(item);
            }

        }
    }
}
