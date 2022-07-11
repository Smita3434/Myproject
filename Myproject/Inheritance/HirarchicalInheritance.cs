using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Inheritance
{
    class Animal
    {
        public int speed = 1;
        void mySpeed()
        {
            Console.WriteLine(speed);
        }
    }
    class Dog:Animal
    {
        public void show()
        {
            speed = 5;
            Console.WriteLine("Dog Speed="+speed);
        }
    }
    class Leford:Animal
    {
        public void display()
        {
            speed = 20;
            Console.WriteLine("Leford Speed="+speed);
        }

    }
    class Horse:Animal
    {
        public void output()
        {
            speed = 15;
            Console.WriteLine("Horse Speed="+speed);
        }
    }
    class HirarchicalInheritance
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.show();

            Leford l = new Leford();
            l.display();

            Horse h = new Horse();
            h.output();
        }
    }
}
