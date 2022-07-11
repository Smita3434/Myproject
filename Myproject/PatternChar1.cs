using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class PatternChar1
    {
        /*
            D C B A
            D C B
            D C
            D
         */
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'D'; i++)
            {
                for (char j = 'D'; j>=i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
