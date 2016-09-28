using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int increase = i;
                int decrease = n;
                for (int j = 1; j<= n; j++)
                {
                    if (increase < n)
                    {
                        Console.Write(increase + " ");
                        increase++;
                    }
                    else
                    {
                        Console.Write(decrease + " ");
                        decrease--;
                    }
                }
                Console.WriteLine();
            }
               
        }
    }
}
//2*n - num