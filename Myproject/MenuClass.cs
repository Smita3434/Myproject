using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class MenuClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
             
            Console.WriteLine("Enter your choice:");
            Console.WriteLine("1.Addition \t 2.Sustraction \t 3.Multiplication \t 4.Division");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Addition:" +(num1 + num2));
                    break;

                case 2:
                    Console.WriteLine("Subtraction:" + (num1 - num2));
                    break;

                case 3:
                    Console.WriteLine("Multiplication:" + (num1 * num2));
                    break;

                case 4:
                    Console.WriteLine("Division:" + (num1 / num2));
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }

        }
    }
}
