//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace LINQDemo
//    {
//        class Program
//        {
//            static void Main(string[] args)
//            {
//                string sentence = "Welcome to Dotnet Tutorials ";

//                int wordCount = sentence.GetWordCount();

//                Console.WriteLine($"Count : {wordCount}");
//                Console.ReadKey();
//            }
//        }

//        public static class ExtensionHelper
//        {
//            public static int GetWordCount(this string str)
//            {
//                if (!String.IsNullOrEmpty(str))
//                    return str.Split(' ').Length;
//                return 0;
//            }
//        }
//    }

using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> EvenNumbers = Enumerable.Where(intList, n => n % 2 == 0);

            Console.ReadKey();
        }
    }
}