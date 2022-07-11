using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class ForLoopingSumOfdigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value:");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for(;num>0;num=num/10)
            {
                int r = num % 10;
                sum = sum + r;
            }
            Console.WriteLine(sum);
        }
    }
}
