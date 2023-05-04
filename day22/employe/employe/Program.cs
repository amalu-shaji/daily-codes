using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace LinQDemo4

{

    class Program

    {

        static void Main(string[] args)

        {

            List<Employee> EmployeesList = new List<Employee>();

            EmployeesList.Add(new Employee("Arun", "Hiderabad"));

            EmployeesList.Add(new Employee("Ram", "Kochi"));

            EmployeesList.Add(new Employee("Reda", "Mumbai"));

            EmployeesList.Add(new Employee("Adarsh", "Indore"));

            EmployeesList.Add(new Employee("Thomas", "Aluva"));

            EmployeesList.Add(new Employee("Vargh", "Kerala"));

            EmployeesList.Add(new Employee("hgyjt", "fghgff"));

            var Query = from Employee emp in EmployeesList

                        orderby emp.City

                        group emp by emp.City;

            foreach (var e in Query)

            {

                Console.WriteLine("Employee with " + e.Key + " City: ");

                foreach (var nm in e)

                {

                    Console.WriteLine(" " + nm.Name);

                }

            }

        }

    }

}
