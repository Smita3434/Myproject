using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOps
{
    class Constructor
    {
        String brand;
        int price;
        int a=7;

        
        public Constructor(string theBrand, int thePrice)
        {
            this.brand = theBrand;
            this.price = thePrice;
        }
        void passbyRef(ref int a, ref int b)
        {
            int c = a + b;
            Console.WriteLine(c);

        }
        void passbyvalue(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        void show()
        {
            Console.WriteLine(a);

        }
        void read(int a)
        {
            this.show();
        }
 
     
       
        static void Main(string[] args)
        {
            Constructor car = new Constructor("BMW",5000000);

            Console.WriteLine("Brand="+car.brand);
            Console.WriteLine("Price="+car.price);

            Console.WriteLine("enter the value a :");
            int c1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the value b:");
            int c2 = Convert.ToInt32(Console.ReadLine());

            car.passbyRef(ref c1, ref c2);
            car.passbyvalue(c1, c2);
        }
    }
}
