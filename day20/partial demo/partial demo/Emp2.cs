using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace partial_demo
{
    internal partial class Emp
    {
        public void Display()
        {
            Console.WriteLine(EmpId);
            Console.WriteLine(Name);
        }
    }
}
