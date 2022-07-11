using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TEST_Week2
{
    class WAP_Q6
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the num");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=num;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
