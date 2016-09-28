using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Even Number: ");
            long check = 999999999999999;
            for (int i = 0; i < check; i++)
            {
              
                try
                {
                    
                    int n = int.Parse(Console.ReadLine());

                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: {0}", n);
                        check = 0;

                    }
                    else if (n % 2 != 0)
                    {
                        Console.WriteLine("The number is not even.");
                        
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid number!");
                }
               


            }


        }
    }
}
