using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class WhileLoopPalindrom
    {
        static void Main(string[] args)
        {
            int num, r, sum = 0, i;

            Console.WriteLine("Enter the Value:");
            num = Convert.ToInt32(Console.ReadLine());

            i = num;
            while(i != 0)
            {
                r = i % 10;
                sum = sum * 10 + r;
                i = i / 10;
            }
            if (sum==num)
            {
                Console.WriteLine("{0} is a Palindrome value",num);
            }
            else
            {
                Console.WriteLine("{0} is a not Palindrome value",num);
            }
        }
    }
}
