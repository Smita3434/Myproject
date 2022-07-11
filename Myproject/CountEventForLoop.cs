using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    // Even number between 1 to 20.
    class CountEventForLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even Number between 1 to 20");
           
            for(int i=1;i<=20;i++)
            {
                 if(i%2==0)
                {
                    Console.WriteLine("Even number is:" +i);
                }
            }
        }
    }
}
