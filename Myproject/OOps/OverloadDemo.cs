using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOps
{
    class OverloadDemo
    {
        void addition()
        {
            Console.WriteLine(10+20);
        }
        void addition(int x,int y)
        {
            Console.WriteLine(x+y);
        }
        void addition(float a,float b)
        {
            Console.WriteLine(a+b);
        }
        void addition(int x,int y,int z)
        {
            Console.WriteLine(x+y+z);
        }
        static void Main(string[] args)
        {
            OverloadDemo d = new OverloadDemo();

            d.addition();
            d.addition(3.4f,7.6f);
            d.addition(4, 5, 3);
            d.addition(1, 2);

        }
    }
}
