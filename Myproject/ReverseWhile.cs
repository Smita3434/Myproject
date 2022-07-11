using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class ReverseWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int revers = 0;

            while(num>0)
            {
                int r = num % 10;
                revers = revers * 10 + r;
                num = num / 10;
            }
            Console.WriteLine("Revers number:"+revers);
        }
    }
}
