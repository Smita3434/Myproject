using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOps
{
    class Animal
    {
        public int legs = 4;
    }
    class cat:Animal
    {
        public void show()
        {
            Console.WriteLine(legs);
        }
    }
    class singleDemo
    {
        static void Main(string[] args)
        {
            cat c = new cat();
            c.show();

        }
    }
}
