using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Inheritance
{
    class ElectivcalVehicle
    {
        public string name = "Ather";
        public void display()
        {
            Console.WriteLine(name);
        }
       
    }
    class Ather:ElectivcalVehicle
    {
        public int price = 2000000;
        public void show()
        {
            Console.WriteLine(price);
        }
    }
    class SingleInheritance1
    {
        static void Main(string[] args)
        {
            Ather a = new Ather();
            a.show();
            a.display();
        }
    }
}
