using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class Square
    {
        static void Main(string[] args)
        {
            int side,area;

            Console.WriteLine("Enter the side of square=");
            side = int.Parse(Console.ReadLine());

            area = side * side;
            Console.WriteLine("area of Square:" +area);
        }
    }
}
