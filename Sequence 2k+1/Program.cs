﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());
            int num = 1;
            for (num = 1; num <= n  ; num = (num*2)+1)
            {
                Console.WriteLine(num);
            }
        }
    }
}
