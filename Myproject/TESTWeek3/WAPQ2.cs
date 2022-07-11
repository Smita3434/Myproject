using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TESTWeek3
{
    class WAPQ2
    {
        static int mcCartyCounter = 100;
        public static int mcCarthy(int n)
        {
            mcCartyCounter++;
            if (n > 100)
                return n - 10;
            else
                return mcCarthy(n + 11);
        }
        public static void Main(String[] arg)
        {
            Console.WriteLine(mcCarthy(100) + "  " + mcCartyCounter);
        }

    }
}
