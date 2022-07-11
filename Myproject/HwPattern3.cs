using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class HwPattern3
    {
        /*
                *     *
                * *   *
                *   * *
                *     *
         */
        static void Main(string[] args)
        {

            int n = 4;
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    if(j==1 || j==n || i==j)
                    {
                        Console.Write(" *" ,j);
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
