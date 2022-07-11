using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    //Write a program to input a number and check whether it is greater than 5 or not.
    class Greater5
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Enter the value a:");
            a = Convert.ToInt32(Console.ReadLine());

            if(a>5)
            {
                Console.WriteLine("a is greater");
            }
            else
            {
                Console.WriteLine("a is not greater");
            }
        }
    }
}
