using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efdemo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EMPDBEntities e=new EMPDBEntities();
            foreach(var item in e.Employee2)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
