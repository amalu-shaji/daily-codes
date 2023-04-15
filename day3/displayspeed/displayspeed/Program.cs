using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace displayspeed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d, t;
            Console.WriteLine("enter the distance :");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the time :");
            t = double.Parse(Console.ReadLine());
            double res1 = speed1(d, t);
            Console.WriteLine("speed in km/hr is :" + res1);
            double res2 = speed2(d, t);
            Console.WriteLine("speed in mile/hr is :" + res2);
            Console.ReadKey();

        }
        static double speed1(double d, double t)
        {

            double s1;
            s1 = d * t;
            return s1;
        }
        static double speed2(double d, double t)
        {
            double s2;  
            s2 = (d * t) * 0.62;
            return s2;
         }

       }
   }

