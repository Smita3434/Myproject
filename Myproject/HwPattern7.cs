using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    /*
            1
            10
            101
            1010
            10101
     */
    class HwPattern7
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if(j%2==0)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
