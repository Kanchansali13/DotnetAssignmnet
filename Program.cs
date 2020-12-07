using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet4_2
{
    class Program
    {
        static void Main()
        {
            Employee[] employees = new Employee[3];

            for (int i = 0; i < employees.Length; i++)
            {
                string name = Console.ReadLine();
                decimal salary = Convert.ToDecimal(Console.ReadLine());
                employees[i] = new Employee { Name = name, Salary = salary };
            }

            List<Employee> list = employees.ToList<Employee>();
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Salary);
            }
            Console.ReadLine();
        }
    }

    class Employee
    {
        public string name;
        public decimal salary;
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public decimal Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return salary;
            }
        }
    }
}
