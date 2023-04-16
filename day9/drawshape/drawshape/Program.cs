using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawshape
{
   class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();

            s1.DrawShape();

            Circle c1 = new Circle();

            c1.DrawShape();

            Rectangle r1 = new Rectangle();

            r1.DrawShape();

            Shape s2 = new Circle();
         
         s2.DrawShape();

        Shape s3 = new Rectangle();
        s3.DrawShape();


        }
    }
}
