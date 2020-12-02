using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet2
{
    class Program
    {
        static void Main()
        {
            Manager m = new Manager("kanchan",12,12345,"manager");
            Console.WriteLine(m.EmpNo + " " + m.Name + " " + m.Deptno + " " + m.Basic + " " + m.Designation + " "+m.CalcNetSalary()); 
            Console.ReadLine();
            GeneralManager gm = new GeneralManager("abc",13,4567,"generalmanager","xyz");
            Console.WriteLine(gm.EmpNo + " " + gm.Name + " " + gm.Deptno + " " + gm.Basic + " " + gm.Designation +" " +gm.Perks+" "+ gm.CalcNetSalary());
            Console.ReadLine();
            CEO ce = new CEO("aaa",123,89075);
            Console.WriteLine(ce.EmpNo + " " + ce.Name + " " + ce.Deptno + " " + ce.Basic + " " + ce.CalcNetSalary());
            Console.ReadLine();
        }
    }

    public abstract class Employee
    {
        public static int flag = 0;
        public Employee(string Name, short Deptno,decimal Basic)
        {
            empNo = ++flag;
            
            this.Name = Name;
            this.Deptno = Deptno;
            this.Basic = Basic;

        }
        #region properties
        private string name;
        public string Name
        {
            set
            {
                if (value != null)
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
        private int empNo;
        public int EmpNo
        {
            get
            {
                return empNo;
            }
            private set { empNo = value; }
        }
        private short deptno;
        public short Deptno
        {
            set
            {
                if (value > 0)
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
        //private decimal B;
        public abstract decimal Basic
        {
            set; get;
        }
        #endregion
        #region methods
        public abstract decimal CalcNetSalary();
        #endregion
    }

    public class Manager : Employee
    {
        #region properties
        private string designation;
        public string Designation
        {
            set
            {
                if(value!=null)
                {
                    designation = value;
                }
                else
                {
                    Console.WriteLine("designation should not be null");
                    Console.ReadLine();
                }
            }
            get
            {
                return designation;
            }
        }
        private decimal basic;
        public override decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                basic = value;
            }

        }

        #endregion
        #region constructor
        public Manager(string Name,short Deptno,decimal Basic,string Designation) : base(Name,Deptno,Basic)
        {
            this.Designation = Designation;
        }
        #endregion
        public override decimal CalcNetSalary()
        {
            return Basic + 5000;
        }
    }

    public class GeneralManager : Manager
    {
        #region properties
        private string perks;
        public string Perks
        {
            set
            {
                perks = value;
            }
            get
            {
                return perks;
            }
        }
        private decimal basic;
        public override decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                basic = value;
            }
        }
        #endregion
        public GeneralManager(string Name, short Deptno, decimal Basic, string Designation,string Perks):base( Name,Deptno,Basic,Designation)
        {
            this.Perks = Perks;
        }
        public override decimal CalcNetSalary()
        {
            return basic+20000;
        }
    }

    public class CEO : Employee
    {
        public CEO(string Name,short Deptno,decimal Basic):base(Name, Deptno, Basic)
        {
            
        }
        public override decimal Basic 
        { 
            get ; set ; 
        }

        public override sealed decimal CalcNetSalary()
        {
            return Basic + 60000; 
        }
    }



}
