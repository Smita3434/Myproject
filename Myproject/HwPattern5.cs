using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class HwPattern5
    {
        /*
                1
                2 3
                4 5 6
         */
        static void Main(string[] args)
        {
            int k = 1;

            for(int i=1;i<=3;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(k++);
                }
                Console.WriteLine();
            }
        }
    }
}
