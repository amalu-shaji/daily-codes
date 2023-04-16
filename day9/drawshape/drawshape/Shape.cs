using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawshape
{
    public class Shape
    {
        public  virtual void DrawShape()
        {
            Console.WriteLine("Drawing shape");
        }
    }   
        public class Circle : Shape
        {
            public  override void DrawShape()
            {
                Console.WriteLine("drawing circle!");
            }
        }
        public class Rectangle : Shape
        {
            public override void DrawShape()
            {
                Console.WriteLine("drawing rectangle!");
                Console.ReadKey();
            }
        }
    
}
    


