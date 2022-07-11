using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class Addition
    {
        static void Main(string[] args)
        {
            int num1, num2, add;
            Console.WriteLine("Enter Number1=");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number2=");
            num2 = int.Parse(Console.ReadLine());

            add = (num1 + num2);

            Console.WriteLine("Addition of two numbers="+ add);

        }
    }
}
