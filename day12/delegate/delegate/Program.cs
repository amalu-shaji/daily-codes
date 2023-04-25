using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    internal class Program
    {
        //static void Add(int i, int j)
        //{
        //    Console.WriteLine("sum :" + (i + j));
        //}
        //static void sub(int i, int j)
        //{
        //    Console.WriteLine("sub:" + (i - j));
        //}
        //public delegate void reftomethod (int i, int j);
        //static void Main(string[] args)
        //{
        //    Add(10, 20);
        //    reftomethod r1 = Add;
        //    r1(10,20);
        //    reftomethod r2 = sub;
        //    r2.Invoke(10,20);
        //}


        static void Add(int i, int j)
        {
            Console.WriteLine("sum :" + (i + j));
        }
        static void sub(int i, int j)
        {
            Console.WriteLine("sub:" + (i - j));
        }
        public delegate void reftomethod(int i, int j);
        static void Main(string[] args)
        {
            reftomethod multicast = Add;
            multicast += sub;
            multicast(20, 10);
        }
    }
}