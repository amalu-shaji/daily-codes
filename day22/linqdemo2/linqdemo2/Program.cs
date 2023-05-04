using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqdemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            var upperLowerWords = from w in words
                                  select (Upper: w.ToUpper(), Lower: w.ToLower());

            foreach (var ul in upperLowerWords)
            {
                Console.WriteLine($"Uppercase: {ul.Upper}, Lowercase: {ul.Lower}");
            }
        }
    }
}
