using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    /*
        1234
        1234
        1234
        1234
     */
    class PatternSq3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for(int j=1; j<=4; j++)
                {
                    Console.Write("" + (j));
                }
                Console.WriteLine();
            }
        }
    }
        
}
