using @namespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @namespace
{
    public class array
    {
        float[] arr = new float[] { 12.3f, 34.9f, 3f };
        public float this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
    }
    class class1
    {
        static void Main(string[] args)
        {
            array a;
            a = new array();
            a[3] = 34.9f;
            Console.WriteLine(a[3]);
        }
    }
}
