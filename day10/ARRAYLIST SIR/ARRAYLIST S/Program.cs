using System;



using System.Collections;

namespace ComparerDemo

{

    class Program

    {

        static void Main(string[] args)

        {

            ArrayList ilist = new ArrayList { 50, 20, 30 };

            ilist.Sort();

            foreach (var item in ilist)

            {

                Console.WriteLine(item);

            }

            ArrayList el = new ArrayList

   {

    new Emp(101, "Ram", 5000M),

    new Emp(102, "Shyam", 2000M),

    new Emp(103,"Hari",3500M)

   };

            foreach (var item in el)

            {

                Console.WriteLine(item);

            }

            Console.WriteLine("Sorting");

            el.Sort();

            foreach (var item in el)

            {

                Console.WriteLine(item);

            }

        }

    }

}

/*************************** Emp Class ************************************/

using System;

namespace ComparerDemo

{

    public class Emp : IComparable

    {

        private int _empid;

        public int EmpId

        {

            get { return _empid; }

            set { _empid = value; }

        }

        private string _empname;

        public string EmpName

        {

            get { return _empname; }

            set { _empname = value; }

        }

        private decimal _salary;

        public decimal Salary

        {

            get { return _salary; }

            set { _salary = value; }

        }

        public Emp()

        {

        }

        public Emp(int empid, string empname, decimal salary)

        {

            this.EmpId = empid;

            EmpName = empname;

            Salary = salary;

        }

        public override string ToString()

        {

            return $"Emp ID:{EmpId} Emp Name:{EmpName} Emp Salary:{Salary}";

        }

        public override bool Equals(object obj)

        {

            Emp temp = obj as Emp;

            return temp.EmpId == this.EmpId;

        }

        public override int GetHashCode()

        {

            return base.GetHashCode();

        }

        public int CompareTo(object obj)

        {

            Emp temp = obj as Emp;

            return Salary.CompareTo(temp.Salary);

        }

    }

}