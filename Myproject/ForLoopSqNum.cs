using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class ForLoopSqNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square Between 1 to 15" +"\n");
             for(int i=1;i<=15;i++)
            {
                Console.WriteLine(i + "*" + i + "=" + (i * i));
            }
        }
    }
}
