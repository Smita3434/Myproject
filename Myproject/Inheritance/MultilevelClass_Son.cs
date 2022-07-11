using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Inheritance
{
    class MultilevelClass_Son:Father1
    {
        public void Display2()
        {
            Console.WriteLine("Son.. ");
        }
        static void Main(string[] args)
        {
            MultilevelClass_Son s = new MultilevelClass_Son();
            s.Display();
            s.Display1();
            s.Display2();
            Console.Read();
        }
    }
    class Father1:GrandFather1
    {
        public void Display1()
        {
            Console.WriteLine("Father...");
        }

    }
    class GrandFather1
    {
        public void Display()
        {
            Console.WriteLine("GrandFather");
        }
    }
}
