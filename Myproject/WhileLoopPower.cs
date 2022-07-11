using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class WhileLoopPower
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Base:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Exponent:");
            int expo = Convert.ToInt32(Console.ReadLine());
            int power = 1;
            int i = 1;

            while (i <= expo)
            {
                power = power * number;
                i++;
            }

            Console.WriteLine(power);
        }
    }
}
