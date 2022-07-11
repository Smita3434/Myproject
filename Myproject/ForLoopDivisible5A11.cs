using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class ForLoopDivisible5A11
    {
        static void Main(string[] args)
        { 
            for(int i=1;i<=15;i++)
            {
                if((i%5==0)||(i%11==0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
