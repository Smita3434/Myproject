using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOps
{
    class StaticMethodDemo
    {
        static int y = 10;
        int x = 300;

        static StaticMethodDemo()
        {
            Console.WriteLine("this is default");
        }
        void show()
        {
            y = 40;
            Console.WriteLine("this is show"+y+" "+x);
        }
        static void read()
        {
            StaticMethodDemo d = new StaticMethodDemo();
            d.show();
            StaticMethodDemo.read();
            StaticMethodDemo d1 = new StaticMethodDemo();
            StaticMethodDemo d2 = new StaticMethodDemo();
        }
    }
}
