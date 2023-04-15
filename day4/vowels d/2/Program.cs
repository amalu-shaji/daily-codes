//Write a program in C# Sharp to count a total number of vowel or consonant in a string

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i = 0, cons = 0, vowel = 0;
            Console.WriteLine("enter the string");
            str = Console.ReadLine();
            Console.WriteLine("The number of vowels are" + vowel);
            Console.WriteLine("The number of consonents are " + cons);
            Console.ReadKey();

            for (i = 0; i < str.Length; i++)
            {
                if ((str[i] == 'A') || (str[i] == 'E') || (str[i] == 'I') || (str[i] == 'O') || (str[i] == 'U'))
                {
                    vowel++;
                }

                else if ((str[i] >= 'a') && (str[i] <= 'z') || (str[i] >= 'A') && (str[i] <= 'Z'))

                {

                    {
                        cons++;
                    }
                }

            }
        }
    }
}
