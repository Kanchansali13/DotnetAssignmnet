using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter number of batches: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int[][] cdac = new int[b][];

            Console.WriteLine("enter number of students in kharghar: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter number of students in juhu: ");
            int s = Convert.ToInt32(Console.ReadLine());

            cdac[0] = new int[k];
            cdac[1] = new int[s];

            for (int i=0; i < cdac.Length;i++)
            {
                for(int j=0;j<cdac[i].Length;j++)
                {
                    Console.Write("marks for student from index {0} {1}: ", i, j);
                    cdac[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for (int i = 0; i < cdac.Length; i++)
            {
                for (int j = 0; j < cdac[i].Length; j++)
                {
                    Console.WriteLine("marks for student from index {0} {1} are: {2} ", i, j,cdac[i][j]);
                   
                }
                Console.ReadLine();
            }

        }
    }
}
