using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class NestedLoopTable
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("{1}*{0}={2}\t\t", i, j, (i * j));
                }
                Console.WriteLine();
            }
        }

    }
}
