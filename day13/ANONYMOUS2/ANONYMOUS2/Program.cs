using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ANONYMOUS2
{

    internal class Program
    {
        public delegate int Sum(int x, int y);
        static void Main(string[] args)
        {
            int result;
            {
                Sum s = delegate (int m, int n)
                {
                    return n + m;
                };
                result = s(10, 20);
                Console.WriteLine(result);
            }
        }
    }
}
