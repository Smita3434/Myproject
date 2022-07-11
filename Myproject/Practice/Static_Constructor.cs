using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Practice
{
    internal class Static_Constructor
    {
        int a, b;
        static int a1, b1;
        static Static_Constructor()
        {
            // static variable
            Console.WriteLine("static constructor");
        }
    }
    class A
    {
        public void displauy()
        {
            // a1,b1 - only once static constructor will be the 1st to be called
            Static_Constructor a = new  Static_Constructor(); // a,b
            Static_Constructor a1 = new Static_Constructor();//a,b
            Static_Constructor a2 = new Static_Constructor();//a,b
            Static_Constructor a3 = new Static_Constructor();//a,b
        }
    }
}
