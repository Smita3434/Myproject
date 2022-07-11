using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOps
{
    class PassbyValue
    {
        void swapbyref(ref int x, ref int y)
        {
            Console.WriteLine("Before swap in swap method=="+x+" "+y);
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("after swap in swap method"+x+" "+y);
        }

        void swapbyvalue(int x,int y)
        {
            Console.WriteLine("Before swap in swap method=="+x+" "+y);
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("after swap in swap method" + x + " " + y);

        }
        static void Main(string[] args)
        {
            PassbyValue p = new PassbyValue();
            Console.WriteLine("enter the num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            p.swapbyref(ref num1, ref num2);
            Console.WriteLine("after swap in main "+num1+" "+num2);

            Console.WriteLine("////////////////////////////");

            p.swapbyvalue(num1, num2);
            Console.WriteLine("after swap in main"+num1+" "+num2);
        }
    }
}
