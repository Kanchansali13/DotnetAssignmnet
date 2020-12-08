using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_1
{
    class Program
    {
        static void Main()
        {
           Func<decimal, decimal, decimal, decimal> o2 = (decimal P, decimal N, decimal R)=> (P * N * R) / 100;
           Console.WriteLine("SI: "+o2(1000, 2, 4)); 


          Func<int,int,bool> o3= (int a, int b)=> (a > b) ? true : false;
          Console.WriteLine("a is greater than b flag: " + o3(3, 4));

          Predicate<int> o4=(int num)=> num % 2 == 0;
          Console.WriteLine("num is even flag: " + o4(3));

           Func<Employee, decimal> o5 = (Employee e) => e.Basic;
           Employee e1 = new Employee("kanchan", 98000, 500);
           Console.WriteLine("basic is: "+o5(e1));

            Func<Employee,bool> o6= (Employee e)=> (e.Salary > 10000) ? true : false;
            Console.WriteLine("is salary is grater than 10000: " + o6(e1));

            Console.ReadLine();
        }

        

    }

    public class Employee
    {
        public Employee(string Name="abc", decimal Salary=15000, decimal Basic=1000)
        {
            this.Name = Name;
            this.Salary = Salary;
            this.Basic = Basic;
        }

        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal Basic { get; set; }
    }
}
