﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class OperatorDemoEq
    {
        static void Main(string[] args)
        {
            int x;

            x = 5 + 5 * 2 / 2;
            Console.WriteLine("x=" +x);

            x = 25 + 3 / 2 * 4 + 4;
            Console.WriteLine("x=" + x);

            x = 6 * 2 / 2 + (3 + 3 / 2);
            Console.WriteLine("x=" + x);

            x = 51 % 9 * 3 + 7 * 6 / 2;
            Console.WriteLine("x=" + x);

            x = 72 / 8 + 3 / 2 * 4;
            Console.WriteLine("x=" + x);

            x = 7 * 7 * 7 / 7 + 7;
            Console.WriteLine("x=" + x);

            x = 1 * 4 / 4 + 2 * 2;
            Console.WriteLine("x=" + x);
        }
    }
}
