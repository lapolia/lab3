﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите а и б ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}+{1}={2}", a, b, a + b);

            Console.WriteLine("{0}-{1}={2}", a, b, a - b);

            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);

            Console.ReadKey();

        }
    }
}
