﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class OperatorDemo
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 2;

            //int x = a++ + b++;
            //Console.WriteLine(x + "" +a + "" +b);

            int x = ++a + ++b;
            Console.WriteLine(x + "" + a + "" + b);

            x = a-- + b++;
            Console.WriteLine(x + "" + a + "" + b);

            x = a++ + --b + a;
            Console.WriteLine(x + "" + a + "" + b);

            x = --b - b - a--;
            Console.WriteLine(x + "" + a + "" + b);

            x = ++a - ++b + a;
            Console.WriteLine(x+ "" +a+ "" +b);
        }
    }
}
