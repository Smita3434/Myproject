using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class ForLoopPower
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Base:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Exponent:");
            int expo = Convert.ToInt32(Console.ReadLine());

            int power = 1;
            for(int i=1;i<=expo;i++)
            {
                power = power * number;
                
            }
            Console.WriteLine(power);
        }
    }
}
