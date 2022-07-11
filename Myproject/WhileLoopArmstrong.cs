using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class WhileLoopArmstrong
    {
        static void Main(string[] args)
        {
            int num,i, r, sum = 0;

            Console.WriteLine("Enter the Number:");
            num = Convert.ToInt32(Console.ReadLine());
           i = num;
            while(i !=0)
            {
                r = i % 10;
                sum = sum + (r * r * r);
                i = i / 10;
            }
            if(sum==num)
            {
                Console.WriteLine("{0} is an Armstrong number",num);
            }
            else
            {
                Console.WriteLine("{0} is not an Armstrong number",num);
            }
        }
    }
}
