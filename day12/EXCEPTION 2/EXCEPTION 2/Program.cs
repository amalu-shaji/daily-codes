using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEPTION_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 2;
            int[] a = new int[5];
            try
            {
                int i = 10 / b;
                a[10] = 9;
            }

              
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero error");
            }
            catch (IndexOutOfRangeException e) {
                Console.WriteLine("index out of bounds");
                
             }
            finally { Console.WriteLine("finally");
                Console.WriteLine("remaining program");
            }
        }
    }
}

