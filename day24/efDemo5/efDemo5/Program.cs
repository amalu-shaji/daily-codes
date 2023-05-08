using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace efDemo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EMPDBEntities e = new EMPDBEntities();
            foreach (var item in e.Employee2)
            {
                Console.WriteLine(item.name);
            }
            //insert
            //using (var context = new EMPDBEntities())
            //{
            //    var emp = new Employee2()
            //    {
            //        name = "raj",
            //        empid = 678,
            //        salary = 5000000,
            //    };
            //    context.Employee2.Add(emp);
            //    context.SaveChanges();
            //}
            //update
            //using (var context = new EMPDBEntities())

            //{

            //    var std = context.Employee2.First<Employee2>();

            //    std.name = "swathi";

            //    context.SaveChanges();

            //}

            //            //delete

            using (var context = new EMPDBEntities())

            {

                var std = context.Employee2.First<Employee2>();

                context.Employee2.Remove(std);

                context.SaveChanges();


            }
            //insert
            using (var context =new EMPDBEntities()) 
            {
                var std = new Employee2()

                { 
                   name = "ramcharan",
                   empid =93809803,




            
        }
    }
}
