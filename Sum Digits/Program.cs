using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int res = 0;
            for (int i = num; num > 0; num = num/10)
            {
                res =  res + (num % 10);
            }
            Console.WriteLine(res);
        }
    }
}
