using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class PNCondition
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the num:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("number is Positive");
            }
            else if(num < 0)
            {
                Console.WriteLine("number is Negative");
            }
            else
            {
                Console.WriteLine("number is Zero");
            }
        }
    }
}
