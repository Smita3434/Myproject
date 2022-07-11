using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TEST_Week2
{
    /*	Pattern=
                1
                21
                321
                4321
                54321
    */

    class WAP_Q4
    {
        static void Main(string[] args)
        {
            int i, j;
            for(i=1;i<=5;i++)
            {
                for(j=i;j>=1;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
