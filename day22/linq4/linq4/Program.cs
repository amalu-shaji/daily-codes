using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dalia", "rosde", "lilly", "daffodil" };

            var fQuery = from flower in flowers

                         where flower.StartsWith("d")

                         select flower;

            foreach (string f in fQuery)
            {

                Console.WriteLine(f);

            }
        }
    }
}
