using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOps
{
    class OverloadingArea
    {
        void findarea(int a,int b)
        {
            Console.WriteLine("Area of Rectangle with Lenght "+a+" and Breadth "+b+" is:"+(a*b));
        }

        void findarea(float r)
        {
            Console.WriteLine("Area of Circle with Radius "+r+" is :"+(3.14*r));
        }

        void findarea(int s)
        {
            Console.WriteLine("Area of Square with side"+s+" is:"+(s*s));
        }

        void findarea(double base1, double height)
        {
            Console.WriteLine("Area of Traingle with base"+base1+"and height "+height+" is:"+(1/2*base1*height));
        }
        static void Main(string[] args)
        {
            OverloadingArea d = new OverloadingArea();
            d.findarea(5, 8);
            d.findarea(5.6f);
            d.findarea(7);
            d.findarea(8, 4);
        }
    }
}
