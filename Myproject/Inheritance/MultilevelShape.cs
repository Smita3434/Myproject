using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Inheritance
{
    class Shape
    {
        public String Sname = "Square";

        public void display()
        {
            Console.WriteLine(Sname);
        }
    }
    class Square:Shape
    {
        public void print()
        {
            Console.WriteLine("Area of Square");
        }
    }
    class Area:Square
    {
        public int sq = 5;
        public void output()
        {
            sq = sq * sq;
            Console.WriteLine(sq);
        }
    }
    class MultilevelShape
    {
        static void Main(string[] args)
        {
            Area a = new Area();
            a.display();
            a.print();
            a.output();
        }
    }
}
