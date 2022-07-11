using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TEST_Week2
{
    //2.	WAP to calculate x y  where x is base and y is index without using readymade function.
    class WAP_Q2
    {
        static void Main(string[] args)
        {
            int base_x,index_y;
            int result = 1;

            Console.WriteLine("Enter the base is x:");
            base_x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the index is y:");
            index_y = Convert.ToInt32(Console.ReadLine());

            while(index_y!=0)
            {
                result = result * base_x;
                index_y--;
            }
            Console.WriteLine("Result="+result);
        }
    }
}
