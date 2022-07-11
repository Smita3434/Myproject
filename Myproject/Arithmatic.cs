using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class Arithmatic
    {
        static void Main(string[] args)
        {
            int a, b;
            int add, sub, mul;
            float div;

            Console.WriteLine("Enter the two numbers=");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            add = a + b;
            Console.WriteLine("Addition=" +add);

            sub = a - b;
            Console.WriteLine("Subtraction=" + sub);

            mul = a * b;
            Console.WriteLine("multiplication=" + mul);

            div = a / b;
            Console.WriteLine("Divison=" + div);


        }
        

    }
}
