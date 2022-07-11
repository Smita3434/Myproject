using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class Pattern7
    {
        /*
            4321
            432
            43
            4
         */
        static void Main(string[] args)
        {
            for (int i = 1; i<= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
