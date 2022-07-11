using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOps
{
    class Pen
    {
        string pname;
        string pcolor;
        //Nip nip;
        public Pen(string pname, string pcolor )
        {
            this.pname = pname;
            this.pcolor = pcolor;
        }
        public void show()
        {
            Console.WriteLine(pname);
            Console.WriteLine(pcolor);
        }
    }
    /*class Nip
    {
        string mname;
        public void nip(string mname)
        {
            this.mname = mname;
            Console.WriteLine("the Material use are:" + mname);
        }
    }*/

    class bag
    {
        String brand;
        string color;
        Pen pen;

        public bag(string brand, string color, Pen pen)
        {
            this.brand = brand;
            this.color = color;
            this.pen = pen;
        }
        void display()
        {
            Console.WriteLine(brand);
            Console.WriteLine(color);
            pen.show();

        }
        static void Main(string[] args)
        {
           // Nip n = new nip("Plastic");
            Pen p = new Pen("Trimax", "Black");
            bag b = new bag("Adidas", "Black", p);
            b.display();
            

        }
    }
}



