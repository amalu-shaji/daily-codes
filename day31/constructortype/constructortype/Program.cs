using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructortype
{
    class Program
    {


        //        static void Main(string[] args)
        //        {
        //            student obj1 = new student();
        //            student obj2 = new student();
        //            student obj3 = new student();


        //        }
        //    }
        //    class student
        //    {
        //        public  student()
        //        {
        //            Console.WriteLine( "print reszult");
        //        }
        //    }
        //}
        static void Main()
        {
            ParametrisedConstructorDemo cd = new ParametrisedConstructorDemo(10);
            cd.display();
            Console.ReadLine();

        }

    }
}