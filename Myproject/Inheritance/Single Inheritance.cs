using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Inheritance
{
    class Father
    {
        public int age = 30;
        public void display()
        {
            Console.WriteLine("Father age="+age);
        }
        
    }
    class Son : Father
    {
        int age = 20;
        public void display1()
        {
            Console.WriteLine("Son age="+age);
        }
    }
   
    class Single_Inheritance
    {
        static void Main(string[] args)
        {
            Father f = new Father();
            Son s = new Son();
            s.display();
            s.display1();
        }
    }
    
}
