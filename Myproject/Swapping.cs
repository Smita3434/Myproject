using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class Swapping
    {
        static void Main(string[] args)
        {
            int a = 100, b = 50;
            int temp = 0 ;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a is "+a);
            Console.WriteLine( "b is "+b );

        }
    }
}
