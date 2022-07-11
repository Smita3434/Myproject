using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOps
{
    class ConstructorDemo
    {
        public ConstructorDemo()
        {
            Console.WriteLine("hi am a default");
        }
        public ConstructorDemo(int x)
        {
            Console.WriteLine("this is my parameterized constructor");
        }

        static ConstructorDemo()
        {
            Console.WriteLine("this is static constructor");
        }

        void add()
        {

        }
        private ConstructorDemo(string name)
        {
            Console.WriteLine(name) ;
        }
        static void Main(string[] args)
        {
            ConstructorDemo d = new ConstructorDemo();
            ConstructorDemo d1 = new ConstructorDemo(400);
            ConstructorDemo d2 = new ConstructorDemo("pune");

             
        }
    }
}
