using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Inheritance
{
    class Fruit
    {
        public void display()
        {
            Console.WriteLine("I am Fruit");
        }

    }
    class Mango : Fruit
    {
        public void display1()
        {
            Console.WriteLine("I am King of fruit");
        }
    }
    class SingleInheritance3
    {
        static void Main(string[] args)
        {
            Fruit f = new Fruit();
            Mango m = new Mango();
            m.display();
            m.display1();
        }
    }
}
