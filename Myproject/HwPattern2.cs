﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class HwPattern2
    {
        /*
                * * * *
                *     *
                *     *
                * * * *
         */
        static void Main(string[] args)
        {
            int n = 4;
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    if(i==1 || i==n || j==1 || j==n)
                    {
                        Console.Write(" *");
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
