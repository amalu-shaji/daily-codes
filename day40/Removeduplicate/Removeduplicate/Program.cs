using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Removeduplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n= Convert.ToInt32(Console.ReadLine());
            string[] strings = new string[n];
            for (int i = 0; i < n; i++) 
            {
                strings[i] = Console.ReadLine();
            }
            foreach (string str in strings) 
            {
                string result = RemoveDupicateWord(str);

                Console.WriteLine(result);

            }
        }
        static string RemoveDupicateWord(string sentence)
        {
            string pattern = @"\b(\w+)\b\s+(?=.*\b\1\b)";
            string rep = "";
            Regex regex = new Regex(pattern);
            string result = regex.Replace(sentence, rep);
            return result;
            }
        }
}
