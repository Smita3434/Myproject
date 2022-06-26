using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.ASSIGNMENT_1
{
    class Odd521To299
    {
        static void Main(string[] args)
        {
            int i = 521;
            while(i>299)
            {
             
                    if(i%2!=0)
                {
                    Console.WriteLine(i);
                }
                i--;
                
            }
        }
    }
}
