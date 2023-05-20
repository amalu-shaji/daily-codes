using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            string str;
            //            int l = 0;
            //            Console.WriteLine("ENTER THE STRING");
            //            str = Console.ReadLine();

            //            foreach(char ch in str) 
            //            {

            //                l += 1;

            //            }
            //            l = l - 1;
            //            while(l >=0)
            //            {
            //                Console.Write(str[l]+" ");
            //                l--;
            //            }
            //            Console.WriteLine("length of a string {0}", l);

            //        }
            //    }
            //}
            string str;
            int l, wrd, i;
            Console.WriteLine("enter the string");
            str = Console.ReadLine();
            l = 0;
            wrd = 1;
            while (l <= str.Length - 1)
            {
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\n')
                {
                    wrd++;
                }
                l++;
            }
            Console.WriteLine("number of words in this string{0}", wrd);
        }
    }
}




