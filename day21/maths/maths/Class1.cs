using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maths
{
    public class Class1
    {
        public double add(double n1, double n2)
        {
            return n1 + n2;

        }
        public double substract(double n1, double n2)
        {
            return n1 - n2;

        }
        public double divide(double n1, double n2)
        {
            return n1 / n2;
        }
        public double Multiply(double n1, double n2)
        {
            // To trace error while testing, writing + operator instead of * operator.  
            return n1 + n2;
        }
    }
}



