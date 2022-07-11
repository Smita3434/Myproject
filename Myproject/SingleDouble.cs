using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    // Write a program to input a number and compare whether that number is single digit or double digit.

    class SingleDouble
    {
        static void Main(string[] args)
        {
            int digit;
            Console.WriteLine("Enter the Digit");
            digit = Convert.ToInt32(Console.ReadLine());

            if((digit >= 0 && digit <= 9) || (digit >= -0 && digit <= -9) )
            {
                Console.WriteLine("Its a Single digit");
            }
            else if(digit >= 10 && digit <= 99 || (digit >= -10 && digit <= -99))
            {
                Console.WriteLine("Its a Double digit");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
