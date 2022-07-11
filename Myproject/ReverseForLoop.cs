using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class ReverseForLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int revers = 0;

            for(;num>0;num=num/10)
            {
                int r = num % 10;
                revers= revers * 10 + r;
            }
            Console.WriteLine(revers);
        }
    }
}
