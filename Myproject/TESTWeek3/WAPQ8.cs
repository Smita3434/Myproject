using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TESTWeek3
{
    class WAPQ8
    {
        static void Main(string[] args)
        {
            int n = 50;
            for(int i=1;i<=n;i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("buzzfizz" + " ");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("buzz" + " ");
                }
                else if(i%5==0)
                {
                    Console.WriteLine("Fizz" + " ");
                }
                else
                    Console.Write(i + " ");
            }
        }
    }
}
