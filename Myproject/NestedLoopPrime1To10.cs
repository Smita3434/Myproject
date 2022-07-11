using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class NestedLoopPrime1To10
    {
        static void Main(string[] args)
        {
            int sum = 0;
            bool isPrime = true;                            
           
            Console.WriteLine("Prime Numbers are:");

            for(int i=1;i<=10;i++)
            {
                for(int j=2;j<=10;j++)
                {
                    if(i !=j && i%j==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }
                isPrime = true;
            }
            Console.WriteLine("Prime Sum=" + sum);
        }
    }
}
