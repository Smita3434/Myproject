using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    //Check whether a number is a palindrome or not.
    class ForLoopPalidrom
    {
        static void Main(string[] args)
        {
            int num, r, sum = 0, i;

            Console.WriteLine("Enter the Value:");
            num = Convert.ToInt32(Console.ReadLine());

            for(i=num;num!=0;num=num/10)
            {
                r = num % 10;
                sum = sum * 10 + r;
            }
            if(i==sum)
            {
                Console.WriteLine("{0} is a Palindrome value",i);
            }
            else
            {
                Console.WriteLine("{0} is a not Palindrome value",i);
            }
        }
    }
}
