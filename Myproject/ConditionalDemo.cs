using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class ConditionalDemo
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Emter the value of num1:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Emter the value of num2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine("greater number is:" +num1);
            }
            else
            {
                Console.WriteLine("greater number is:" +num2);
            }
        }
    }
}
