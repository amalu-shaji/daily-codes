using System;
using System.Collections.Generic;


namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("amalu");
            names.Add("anu");
            names.Add("sam");
            names.Add("ram");
            names.Add("kaethik");
            names.Add("manju");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

        }
    }
}
