﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForLoopOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            for (int i = 20; i > 0; i -= 2)
            {
                Console.WriteLine(i);
                i--;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 2; j > 0; j--)
                {
                    Console.WriteLine(i - j);
                }
                Console.WriteLine("Cheri likes loops!");
            }
        }
    }
}
