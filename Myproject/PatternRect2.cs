﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    /*1
      12
      123
      1234*/
    class PatternRect2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("" + (j));

                }
                Console.WriteLine("");

            }
        }
    }
}
