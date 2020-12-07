using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet4_3
{
    class Program
    {
        static void Main()
        {
            List<Employee> list = new List<Employee>();
            for (int i = 0; i < 3; i++)
            {
                string Name;
                decimal Salary;
                Console.WriteLine("Enter name");
                Name = Console.ReadLine();
                Console.WriteLine("Enter salary");
                Salary = Convert.ToDecimal(Console.ReadLine());
                list.Add(new Employee { name = Name, salary = Salary });
            }

            Employee[] employees = list.ToArray();

            foreach (Employee obj in employees)
            {
                Console.WriteLine("name: {0} salary: {1}", obj.name, obj.salary);
            }
            Console.ReadLine();
        }
    }

    class Employee
    {
        public string name { get; set; }
        public Decimal salary { get; set; }


    }
}
