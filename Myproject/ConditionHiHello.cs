using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class ConditionHiHello
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter Number:");
            num = Convert.ToInt32(Console.ReadLine());

            if(num>3 && num<10)
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine(" Hi Hello");
            }
        }
    }
}
