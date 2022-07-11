using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class WhileLoopPrimeNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            Boolean isPrime = true;


            int i = 2;
            while(i<num)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    
                }
                i++;
            }
            if (isPrime == true)
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
