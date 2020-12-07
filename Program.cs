using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main()
        {
            SortedList<int, Employee> emp = new SortedList<int, Employee>();
            string flag = "YES";
            int i = 0;
            int j = 1;
            decimal sal = 1;
            String name;
            decimal salary;
            int empno;
            while(flag=="YES")
            {
                i++;
                string Name = Console.ReadLine();
                decimal Salary = Convert.ToInt32(Console.ReadLine());
                int Empno = Convert.ToInt32(Console.ReadLine());
                emp.Add(i, new Employee(empno = Empno, name = Name, salary = Salary));
                Console.WriteLine("Do you want to enter detail for employee:[YES/NO]:");
                flag = Console.ReadLine();
               
            }

            foreach (KeyValuePair<int,Employee> s in emp )
            {
                if (sal < s.Value.salary)
                {
                    sal = s.Value.salary;

                }
            }
            Console.WriteLine("Highest salary is={0}", sal);

            foreach (KeyValuePair<int, Employee> kvp in emp)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine("name :{0}, Salary:{1},EmpNo:{2}", kvp.Value.name, kvp.Value.salary, kvp.Value.empno);
            }

            Console.WriteLine("Enter employee Number :");
            int empid = Convert.ToInt32(Console.ReadLine());
            foreach (KeyValuePair<int, Employee> obj in emp)
            {
                if (obj.Value.EmpNo == empid)
                {
                    Console.WriteLine("name={0},salary={1}", obj.Value.Name, obj.Value.Salary);
                }

            }

            Console.WriteLine("enter how many employee u want to show");
            int n = Convert.ToInt32(Console.ReadLine());
            foreach (KeyValuePair<int, Employee> obj in emp)
            {
                if (j <= n)
                {
                    Console.WriteLine("name={0},salary={1},empno={2}", obj.Value.Name, obj.Value.Salary, obj.Value.EmpNo);
                    j++;
                }

            }

            Console.ReadLine();
        }
    }

   public class Employee
    {
        public String name;
        public decimal salary;
        public int empno;

        public Employee(int empno, String name, decimal salary)
        {
            this.empno = empno;
            this.name = name;
            this.salary = salary;
        }
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
        public int EmpNo
        {
            set
            {
                empno = value;
            }
            get
            {
                return empno;
            }
        }
    }
}
