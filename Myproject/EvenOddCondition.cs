using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class EvenOddCondition
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the num:");
            num = Convert.ToInt32(Console.ReadLine());

            if(num%2==0)
            {
                Console.WriteLine("number is Even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
        }
    }
}
