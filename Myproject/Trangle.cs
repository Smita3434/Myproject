using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class Trangle
    {
        static void Main(string[] args)
        {
            float base1;
            float height,area;

            Console.WriteLine("Enter the Base");
            base1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Height");
            height = float.Parse(Console.ReadLine());

            area = (base1 * height) / 2;
            Console.WriteLine("Area of Trangle=" + area);
        }
    }
}
