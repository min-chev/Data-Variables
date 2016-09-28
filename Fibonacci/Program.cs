using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n<2)
            {
                Console.WriteLine("1");
            }
            else
            {
                int f0 = 1;
                int f1 = 1;
                int res = 0;
                for (int i = 0; i < n-1; i++)
                {
                    res = f0 + f1;
                    f0 = res - f0;
                    f1 = res;
                }
                Console.WriteLine(res);
            }
            

        }
    }
}
