using codefirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirst
{
    class Program
    {
       static void Main(string[] args)
            {

            using (var ctx = new SchoolContext())
            {
                var stud = new student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
        }
    }

   
