using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Practice
{
     internal class Iterface
    {
    }
    abstract class Shape
    {
        public abstract void area();
        public abstract void perimeter();
    }

    class circle : Shape
    {
        public override void area() { }
        public override void perimeter() { }
    }

    class rectangle : Shape
    {
        public override void area() { }
        public override void perimeter() { }
    }
}
