using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.ASSIGNMENT_1
{
    class HarshadNum
    {
        static void Main(string[] args)
        {
            int num;
            int originalnum, sum = 0;
            Console.WriteLine("enter the number:");
            originalnum = Convert.ToInt32(Console.ReadLine());
            
            int digit;

            num=originalnum;

            while(num!=0)
            {
                digit =  num % 10;
                sum = sum + digit;
                num = num / 10;
            }
            
            if(originalnum%sum==0)
            {
                Console.WriteLine("Harshad Number");
            }
            else
            {
                Console.WriteLine("Not");
            }

            
        }
    }
}
