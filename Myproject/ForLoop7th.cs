using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class ForLoop7th
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 7th number in 1 to 50 is :");
            Console.WriteLine(1);
            for(int i=0;i<=50;i=i+7)
            {
                if(i==0)
                {
                    continue;
                }
                    Console.WriteLine(i);   
            }
        }
    }
}
