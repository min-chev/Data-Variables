using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int a1 = Math.Min(a, b);
            int b1 = Math.Max(a, b);
            int diff = b1 - a1;
            int iterator = Math.Min(diff, a1);
            int oldDivisor = 1;
            int newDivisor = 1;
            for (int i = 1; i <= iterator; i++)
            {
                if (diff % i == 0 && a1 % i == 0)
                {
                    newDivisor = i;
                }
                if (newDivisor > oldDivisor)
                {
                    oldDivisor = newDivisor;
                }

            }

            Console.WriteLine(a == b ? a : oldDivisor);






        }
    }
}
