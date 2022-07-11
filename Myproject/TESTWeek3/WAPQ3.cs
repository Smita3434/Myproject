using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TESTWeek3
{
    class WAPQ3
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'b', 'b', 'c','c','b' };

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
