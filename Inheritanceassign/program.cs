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
            Manager m = new Manager("kanchan",12,2345,"manager");
            Console.WriteLine(m.EmpNo + " " + m.Name + " " + m.Deptno + " " + m.Basic + " " + m.Designation + " "+m.CalcNetSalary()); 
            Console.ReadLine();
            GeneralManager gm = new GeneralManager("abc",13,9567,"generalmanager","xyz");
            Console.WriteLine(gm.EmpNo + " " + gm.Name + " " + gm.Deptno + " " + gm.Basic + " " + gm.Designation +" " +gm.Perks+" "+ gm.CalcNetSalary());
            Console.ReadLine();
            CEO ce = new CEO("aaa",123,89075);
            Console.WriteLine(ce.EmpNo + " " + ce.Name + " " + ce.Deptno + " " + ce.Basic + " " + ce.CalcNetSalary());
            Console.ReadLine();
        }
    }
    public interface IDbFunctions
    {
         decimal CalcNetSalary();
    }
    public abstract class Employee: IDbFunctions
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
        protected decimal basic;
        public abstract decimal Basic
        {
            set; get;
        }
        #endregion
        #region methods
        public abstract decimal CalcNetSalary();
        #endregion
    }

    public class Manager : Employee, IDbFunctions
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
        private new decimal basic;
        public override decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                if(value<5000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("basic is invalid");
                }
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

    public class GeneralManager : Manager, IDbFunctions
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
       private new decimal basic;
        public override  decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                if(value<10000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("basic is invalid");
                }
                
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

    public class CEO : Employee, IDbFunctions
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
