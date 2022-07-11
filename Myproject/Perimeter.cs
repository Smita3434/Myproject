using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    //Write a program to enter length and breadth of a rectangle and find its perimeter.
    class Perimeter
    {
        static void Main(string[] args)
        {
            decimal length, breadth;
            decimal area;


            Console.WriteLine("Enter the length of rectangle:");
            length = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the breadth of rectangle:");
            breadth = decimal.Parse(Console.ReadLine());

            area = 2 * (length + breadth);
            Console.WriteLine("Perimeter of rectangle is:" +area);
        }
    }
}
