using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirst.Entities

{

    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {

        }

        public DbSet<student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}

