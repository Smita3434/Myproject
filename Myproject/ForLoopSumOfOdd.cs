﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class ForLoopSumOfOdd
    {
        static void Main(string[] args)
        {
            int i ,sumodd=0;
            for(i=25;i<=75;i++)
            {
                if(i%2!=0)
                {
                    sumodd = sumodd + i;
                }
            }
            Console.WriteLine("Total Sum:" +sumodd);
        }
    }
}
