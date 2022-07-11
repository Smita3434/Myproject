using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class Pattern6
    {
        /*
           1234
           123
           12
           1
         */
        static void Main(string[] args)
        {
            for (int i = 4; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            

        }
    }
}
