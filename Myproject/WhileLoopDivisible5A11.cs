using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class WhileLoopDivisible5A11
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=15)
            {
                i++;
                if((i%5==0)||(i%11==0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
