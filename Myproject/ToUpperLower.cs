﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class ToUpperLower
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());

            if(ch>= 'A' && ch<='Z')
            {
                ch = (char)(ch + 32);
            }
            else
            {
                ch = (char)(ch - 32);
            }
            Console.WriteLine(ch);
        }
    }
}
