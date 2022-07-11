using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Inheritance
{
    class Car
    {
        public string company = "Maruti";
        public void output()
        {
            Console.WriteLine(company);
        }
    }
    class Maruti : Car
    {
        public string cName = "Swift";
        public void show()
        {
            Console.WriteLine(cName);
        }
    }
    class Swift:Maruti
    {
        public int price = 100000000;
        public void display()
        {
            Console.WriteLine(price);
        }
    }
    class MultilevelCar
    {
        static void Main(string[] args)
        {
            Swift s = new Swift();
            s.output();
            s.show();
            s.display();
        }
    }
}
