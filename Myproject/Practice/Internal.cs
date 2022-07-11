using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Practice
{
    class Internal
    {
        public static void main()
        {
            Internal p1 = new Internal();
            p1.Demo();
        }
        public void Demo()
        {
            Console.WriteLine("InternalDemo assembly - InternalDemo2 namespace - InternalDemo2 class - display method");
        }

        protected internal void ProtectedInternaMethod()
        {
            Console.WriteLine("InternalDemo assembly - Assembly2 namespace - InternalDemo2 class - ProtectedInternaMethod method");
        }
    }
}
