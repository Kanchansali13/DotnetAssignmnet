using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main()
        {
            
            Employee o1 = new Employee("Amol", 123465, 10);
            Console.WriteLine($"employee name is:{ o1.Name}");
            Console.WriteLine($"employee number is:{o1.Empno}");
            Console.WriteLine($"emplyee basic is:{o1.Basic}");
            Console.WriteLine($"employee deptno is:{o1.Deptno}");
            Console.WriteLine($"employee salary is:{o1.GetNetSalary()}");
            Console.WriteLine("************************************************");
            Console.ReadLine();
            Employee o2 = new Employee("Amol", 123465);
            Console.WriteLine($"employee name is:{ o2.Name}");
            Console.WriteLine($"employee number is:{o2.Empno}");
            Console.WriteLine($"emplyee basic is:{o2.Basic}");
            Console.WriteLine($"employee deptno is:{o2.Deptno}");
            Console.WriteLine($"employee salary is:{o2.GetNetSalary()}");
            Console.WriteLine("************************************************");
            Console.ReadLine();
            Employee o3 = new Employee("Amol");
            Console.WriteLine($"employee name is:{ o3.Name}");
            Console.WriteLine($"employee number is:{o3.Empno}");
            Console.WriteLine($"emplyee basic is:{o3.Basic}");
            Console.WriteLine($"employee deptno is:{o3.Deptno}");
            Console.WriteLine($"employee salary is:{o3.GetNetSalary()}");
            Console.WriteLine("************************************************");
            Console.ReadLine();
            Employee o4 = new Employee();
            Console.WriteLine($"employee name is:{ o3.Name}");
            Console.WriteLine($"employee number is:{o3.Empno}");
            Console.WriteLine($"emplyee basic is:{o3.Basic}");
            Console.WriteLine($"employee deptno is:{o3.Deptno}");
            Console.WriteLine($"employee salary is:{o3.GetNetSalary()}");
            Console.WriteLine("************************************************");
            Console.ReadLine();
        }
    }
    class Employee
    {
        public static int flag = 0;
        #region constructor
        public Employee()
        {
            flag++;
            empno = flag;
        }
        public Employee(string name,decimal basic,int empno)
        {
            flag++;
            this.name = name;
            this.basic = basic;
            this.empno = flag;
           

        }
        public Employee(string name, decimal basic)
        {
            flag++;
            this.name = name;
            this.basic = basic;
            this.empno = flag;
            
        }
        public Employee(string name)
        {
            flag++;
            this.name = name;
            this.empno = flag;
           
        }
        #endregion
        #region properties
        private string name;
        public string Name
        {
            set
            {
                if(value!=null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("name is invalid");
                    Console.ReadLine();
                }
            }
            get
            {
                return name;
            }
        }

        private int empno;
        public int Empno
        {
            get
            {
                return empno;
            }
            private set{
                empno=value;
            }
        }

        private decimal basic;
        public decimal Basic
        {
            set
            {
                if(value > 10 && value < 50)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("baisc is not within the range");
                    Console.ReadLine();
                }
            }
            get
            {
                return basic;
            }
        }

        private short deptno;
        public short Deptno
        {
            set
            {
                if(value>0)
                {
                    deptno = value;
                }
                else
                {
                    Console.WriteLine("deptno is invalid ");
                }
            }
            get
            {
                return deptno;
            }
        }
        #endregion

        public decimal GetNetSalary()
        {
            decimal nsalary = basic + 10000;
            return nsalary;
        }
      

    }
}
