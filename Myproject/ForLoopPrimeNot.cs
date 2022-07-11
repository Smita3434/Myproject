using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class ForLoopPrimeNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            Boolean isPrime = true;

            for(int i=2;i<num;i++)
            {
                if(num%i==0)
                {
                    isPrime = false;
                }
            }
            if(isPrime==true)
            {
                Console.WriteLine("number is prime");
            }
            else
            {
                Console.WriteLine("number is not prime");
            }
        }
    }
}
