using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class SwitchWeek
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the Number:");
            num = Convert.ToInt32(Console.ReadLine());
            
            switch(num)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;

                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("wendsdat");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
                
        }
    }
}
