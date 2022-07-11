using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TEST_Week2
{
    class WAP_Q5
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the num:");
            num = Convert.ToInt32(Console.ReadLine());
            int i;
            for(i=1;i<=num;i++)
            {
                Console.WriteLine("The Series are="+(i*i-1));
                //Console.WriteLine(i*i-1);
            }
        }
    }
}
