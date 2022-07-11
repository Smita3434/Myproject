using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    // Write a program to input a number and check if its a multiple of 5.
    class Multial5
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the Number:");
            num = Convert.ToInt32(Console.ReadLine());

            if ((num % 5) == 0)
            {
                Console.WriteLine(" Number " + num + " is multiple of 5");
            }
            else
            {
                Console.WriteLine(" Number " + num + " is not multiple of 5");
            }
        }
    }
}
