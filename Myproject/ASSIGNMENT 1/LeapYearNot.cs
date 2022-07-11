using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.ASSIGNMENT_1
{
    class LeapYearNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year");
            int year = Convert.ToInt32(Console.ReadLine());

            if((year %4 == 0)&& (year %100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a leap year",year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year",year);
            }
        }
    }
}
