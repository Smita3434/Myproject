using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class SwitchOprator
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char op;
            Console.WriteLine("Enter the Number1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Number2 ");
            num2 = Convert.ToInt32(Console.ReadLine());

            op = Console.ReadLine()[0];

            switch(op)
            {
                case '+':
                    Console.WriteLine("Addition=" +(num1+num2));
                    break;

                case '-':
                    Console.WriteLine("Substraction=" + (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("Multiplication=" + (num1 * num2));
                    break;

                case '/':
                    Console.WriteLine("Division=" + (num1 / num2));
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
        }
    }
}
