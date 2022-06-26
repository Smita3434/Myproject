using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.ASSIGNMENT_1
{
    //. WAP a program to check whether entered number is 3 digit or not .If it is a 3 digit no.
    //then do sum of 1st and 3rd digit and print sum
    class WAPQ11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            if(num>99 && num<1000)
            {
               

                Console.WriteLine("It is a 3 digit Number");
            }
            else
            {
                Console.WriteLine("It is not a 3 digit number");
            }
            sum = num = num / 100 + num % 10;
            Console.WriteLine("Addition of 1st and 3rd num is:" +sum);
        }
    }
}
