using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    /* 
        1111
        2222
        3333
        4444
     */
    class PatternSQ1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    
}
