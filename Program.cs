using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet3_3
{
    class Program
    {
        static void Main()
        {
            Student[] s = new Student[5];
            Console.WriteLine("enter details for student: ");
            for(int i=0;i<s.Length;i++)
            {
                s[i] = new Student();
                s[i].Rollno = Convert.ToInt32(Console.ReadLine());
                s[i].Name = Console.ReadLine();
                s[i].Marks = Convert.ToInt64(Console.ReadLine());
            }

            foreach(Student t in s)
            {
                Console.WriteLine(t.Rollno);
                Console.WriteLine(t.Name);
                Console.WriteLine(t.Marks);
                Console.ReadLine();
            }
        }
    }

    public struct Student
    {
        public Student(int rollno=101,string name="hiii",decimal marks=15)
        {
            this.name = name;
            this.rollno = rollno;
            this.marks = marks;
        }

       private string name;
        public string Name
        {
            set
            {
                if(value!=" ")
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }

        private int rollno;
        public int Rollno
        {
            set
            {
                if(value>0)
                {
                    rollno = value;
                }
            }
            get
            {
                return rollno;
            }
        }

        private decimal marks;
        public decimal Marks
        {
            set
            {
                if(value<100)
                {
                    marks = value;
                }
            }
            get
            {
                return marks;
            }
        }
    }
}
