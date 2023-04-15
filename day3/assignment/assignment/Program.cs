using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee(102, "Arun", 25000);
            Console.WriteLine("Enter Employee Id :");
            e1.EmpId=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            e1.Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary :");
            e1.salary = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Employee Details");
            Console.WriteLine("-------------------");
            Console.WriteLine("Emp Id :" + e1.EmpId);
            Console.WriteLine("Name :"+e1.Name);
            Console.WriteLine("Salary :" +e1.salary);
            Console.WriteLine("Employee2 Details");
            Console.WriteLine("----------------------");
            Console.WriteLine("Emp Id :" + e2.EmpId);
            Console.WriteLine("Name :" + e2.Name);
            Console.WriteLine("Salary :" + e2.salary);
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
