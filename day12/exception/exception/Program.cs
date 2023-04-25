using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            int i=0;

        try
            {
                k = k / i;
                System.Console.WriteLine("HELLO");
               
            }

        catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
