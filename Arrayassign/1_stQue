using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnt3
{
    class Program
    {
        
        static void Main()
        {
           
            Employee[] emp = new Employee[3];
            for(int i=0;i<emp.Length;i++)
            {
                emp[i] = new Employee();
                emp[i].Empno= Convert.ToInt32(Console.ReadLine());
                emp[i].Name = Console.ReadLine();
               emp[i].Salary = Convert.ToDecimal(Console.ReadLine());
               
            }

            foreach(Employee m in emp)
            {
                Console.WriteLine(m.Empno);
                Console.WriteLine(m.Name);
                Console.WriteLine(m.Salary);
                Console.ReadLine();
            }

            Console.WriteLine("enter empno to be searched: ");
            int  Empid = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < emp.Length; i++)
            {
                if(Empid==emp[i].Empno)
                {
                    emp[i].Display();
                    break;
                }
            }

            decimal sal = 1;
            for (int i = 0; i < emp.Length; i++)
            {
                if (sal<emp[i].Salary)
                {
                    sal = emp[i].Salary; 
                }
            }

            Console.WriteLine("highest salary is {0}", sal);
            Console.ReadLine();
        }
    }

    public class Employee
    {
       

        private int empno;
        public int Empno
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
        private string name;
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

        private decimal salary;
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


        public void Display()
        {
            Console.WriteLine(Empno+" "+name + " "+salary);
            Console.ReadLine();
        }

    }
}
