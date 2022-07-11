using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Practice
{
    class Polymorphism
    {
        public static void main()
        {
            Polymorphism obj = new Polymorphism();
            obj.display(2, 3);
            obj.display();
            obj.display(2, 2.3f);
            obj.display(1.2f, 3);
        }
        public void display()
        {
            Console.WriteLine("no parameter - display method");
        }

        public void display(int n1)
        {
            Console.WriteLine("int parameter - display method");
        }

        public void display(double n1)
        {
            Console.WriteLine("doble parameter - display method");
        }
        public void display(int n1, int n2)
        {
            Console.WriteLine("2 int parameter - display method");
        }

        public void display(float n1, float n2)
        {
            Console.WriteLine("2 float parameter -display method");
        }

        public void display(int n1, int n2, int n3)
        {
            Console.WriteLine("3 int parameter - display method");
        }
        public double display(int n1, float n2)
        {
            double sum = n1 + n2;
            Console.WriteLine("display method and sum is " + sum);
            return sum;
        }

        public void display(float n2, int n1)
        {
            Console.WriteLine(" 1 float 2 int - display method");
        }
        public void print()// not method overloading
        {
            Console.WriteLine("print method");
        }
    }
}

