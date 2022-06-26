using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.ASSIGNMENT_1
{
    class Switch_Q4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the digit(1-5)");
            int digit=Convert.ToInt32(Console.ReadLine());

            switch(digit)
            {
                case 1:
                        Console.WriteLine("ONE");
                    break;

                case 2:
                        Console.WriteLine("TWO");
                    break;

                case 3:
                    Console.WriteLine("THREE");
                    break;

                case 4:
                    Console.WriteLine("FOUR");
                    break;

                case 5:
                    Console.WriteLine("FIVE");
                    break;

                default:
                    Console.WriteLine("INVALID DIGIT");
                    break;
            }
        }
    }
}
