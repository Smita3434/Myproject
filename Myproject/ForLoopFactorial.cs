﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class ForLoopFactorial
    {
        static void Main(string[] args)
        {
            int num, fact=1;
            Console.WriteLine("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial is:" +fact);
        }
    }
}
