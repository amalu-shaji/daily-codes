using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "rose", "lotus", "lilly", "daffodil" };
            //var fquery =
            //    from flower in flowers
            //    where (flower.StartsWith("d"))
            //    select flower;
            //foreach(string f in fquery)
            //{
            //    Console.WriteLine(f);



            //}
            var fquery= from flower in flowers  
                        let len = flower.Length
                        where len > 5 && len < 10
                        select flower;
            foreach (string f in fquery)
            {
                Console.WriteLine(f);
            }
        }
    }

}