using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class WhileLoopFact
    {
        static void Main(string[] args)
        {
            int num, fact = 1;
            Console.WriteLine("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while( i<=num)
            {
                fact = fact * i;
                i++;
            }
            Console.WriteLine("factorial is:" + fact);
        }
    }
}
