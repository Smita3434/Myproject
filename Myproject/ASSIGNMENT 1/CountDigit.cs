using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.ASSIGNMENT_1
{
    class CountDigit
    {
        static void Main(string[] args)
        {
            long num;
            int count = 0;
            Console.WriteLine("Enter the number");
                num = Convert.ToInt64(Console.ReadLine());

            do
            {
                num = num / 10;
                count++;

            } while (num != 0);
            Console.WriteLine("Number of digit:"+count);
        }
        

    }
}
