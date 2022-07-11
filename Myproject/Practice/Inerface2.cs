using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Practice
{
    class Inerface2
    {
        public static void  Main()
            {

            }
    }
    interface Maruti1
    {
        // property
        // public int Name { get; set; }
        //public Maruti1() { }
        public void speed(); // declaration
        public void texture();
        public void engine();
    }

    interface Maruti2
    {
        // property
        // public int Name { get; set; }
        public void speed(); // declaration
        public void texture();
        public void engine();
    }
    interface Maruti3
    {
        // property
        // public int Name { get; set; }
        public void speed(); // declaration
        public void texture();
        public void engine();
    }
    interface Maruti4
    {
        // property
        // public int Name { get; set; }
        public void speed(); // declaration
        public void texture();
        public void engine();
    }
    class car11 : Maruti1, Maruti2, Maruti3, Maruti4
    {
        public void speed()
        {
            Console.WriteLine("car11 class - speed method");
        }
        public void texture()
        {
            Console.WriteLine("car11 class - texture method");
        }
        public void engine()
        {
            Console.WriteLine("car11 class - engine method");
        }
    }
}
