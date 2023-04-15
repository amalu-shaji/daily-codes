using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    public class Employee
    {
        public int EmpId;
        public string Name;
        public decimal salary;

        public Employee()
        {

        }
        public Employee(int empId, string name, decimal salary)
        {
            EmpId = empId;
            Name = name;
            this.salary = salary;
        }
    }
}
