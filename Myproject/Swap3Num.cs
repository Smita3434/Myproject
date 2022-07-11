using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class Swap3Num
    {
        static void Main(string[] args)
        {
            int a = 4, b = 5, c = 6;
            // Swapping 3 numbers
            a = a + b + c;
            //Console.WriteLine();

            b = a - (b + c);

            c = a - (b + c);

            a = a - (b + c);

            Console.WriteLine("values after swapping are:");
            Console.WriteLine(" a value is "+a);
            Console.WriteLine(" b value is "+b);
            Console.WriteLine(" c value is "+c);
        }
    }
}
