using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class ForLoopArmstrong
    {
        static void Main(string[] args)
        {
            int num, r, sum = 0, i;

            Console.WriteLine("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());

            for(i=num; num!=0;num=num/10)
            {
                r = num % 10;
                sum = sum + (r * r * r);
            }
            if(sum==i)
            {
                Console.WriteLine("{0} is an Armstrong number",i);
            }
            else
            {
                Console.WriteLine("{0} is not an Armstrong number",i);
            }
        }
    }
}
