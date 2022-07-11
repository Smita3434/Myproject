using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.ASSIGNMENT_1
{
    class LCM_GCD
    {
        static void Main(string[] args)
        {
            long num1, num2, LCM, GCD,x;

            Console.WriteLine("Enter the num1");
            num1 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter the num2");
            num2 = Convert.ToInt64(Console.ReadLine());

            while(num2!=0)
            {
                x = num2;
                num2 = num1 % num2;
                num1 = x;
            }
            GCD = num1;
            LCM = (num1 * num2) / GCD;

            Console.WriteLine("LCM="+LCM);
            Console.WriteLine("GCD="+GCD);
        }
    }
}
