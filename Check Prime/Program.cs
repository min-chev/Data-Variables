using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int res = 1;

            if (n < 2)
            {
                res++;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n%i == 0)
                {
                    res++;  
                }
                
                                                                              
            }            
            if (res == 1)
            {
                Console.WriteLine("Prime");
            }
            else 
            {
                Console.WriteLine("Not Prime");
            }
          
             

        }
    }
}
