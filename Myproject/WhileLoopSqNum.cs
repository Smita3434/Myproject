using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class WhileLoopSqNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square Between 1 to 15" + "\n");
            int i = 1;

            while(i<=15)
            {
                Console.WriteLine(i + "*" + i + "=" + (i * i));
                i++;
            }
        }
    }
}
