using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructortype
{
    class ParametrisedConstructorDemo
    {
        int x;
        public ParametrisedConstructorDemo(int i)
        {
            Console.WriteLine(" parametrised constructor is called" + i);
        }
        public void display()
        {

            Console.WriteLine("value of x is:" + x);
        }
    }

}
