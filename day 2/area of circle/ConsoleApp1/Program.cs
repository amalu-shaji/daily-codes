using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = 0.0, area;
            Console.WriteLine("enter the radious:");
            r = double.Parse(Console.ReadLine());
            area= CalcArea(r);
            Console.WriteLine("area of circle having radious {0} is {1}",r, area);
            Console.ReadKey();
            
          
        }
        static double CalcArea(double rr)
        {
            double area = 0.0;
            area = 3.14 * rr * rr;
            return area;
        }
    }
}
