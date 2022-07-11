using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TEST_Week2
{
    class XobinHappy
    {
        static void Main(string[] args)
        {
            int  j, num, sum = 0;
            Console.WriteLine("Enter the Number:");
            num = Convert.ToInt32(Console.ReadLine());

            while(sum!=1 && sum!=4)
            {
                sum = 0;
                while(num>0)
                {
                    j = num % 10;
                    sum = sum + (j * j);
                    num = num / 10;
                }
                num = sum;
            }
            if(sum==1)
            {
                Console.WriteLine("Happy");
            }
            else
            {
                Console.WriteLine("Not Happy");
            }
        }
    }
}
