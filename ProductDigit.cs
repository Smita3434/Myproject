using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.ASSIGNMENT_1
{
    class ProductDigit
    {
        static void Main(string[] args)
        {
            int num, rem, prod = 1;
            Console.WriteLine("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
             
            while(num !=0)
            {
                rem = num % 10;
                prod = prod * rem;
                num = num / 10;
            }
            Console.WriteLine("Product of digit:"+prod);
        }
    }
}
