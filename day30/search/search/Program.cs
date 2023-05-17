//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace search
//{
//    internal class Program
//    {
//        static void Main(string[] args)
        //{
using System;
public class SearchArrayIntegers
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("enter the number of integers");
                int x = Convert.ToInt32(Console.ReadLine());

                int[] list = new int[x];
                for (int i = 0; i < x; i++)
                {
                    list[i] = Convert.ToInt32(Console.ReadLine());
                }

                string y;

                do
                { 
                    Console.WriteLine( "enter the number to be searched");
                    y = Console.ReadLine();

                    if (y != "end")
                    {
                        int yToInt = Convert.ToInt32(y);

                        if (Array.BinarySearch(list, yToInt) >= 0)
                        {
                            Console.WriteLine("The number {0} exist", y);
                        }
                        else
                        {
                            Console.WriteLine("The number {0} not exist", y);
                        }
                    }
                }
                while (y != "end");
            }
        }



         