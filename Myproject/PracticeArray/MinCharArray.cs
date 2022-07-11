using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array
{
    class MinCharArray
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'r', 't', 'e' };

            char min = ch[0];

            for (int i = 0; i < ch.Length; i++)
            {
                if (min > ch[i])
                {
                    min = ch[i];
                }
            }

            Console.WriteLine("Min is=" + min);
        }
    }
}
