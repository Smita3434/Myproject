using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class SwitchDemo3
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter Value:");

            input = Console.ReadLine();

            switch(input)
            {
                case "happy": 
                    Console.WriteLine("Happy");
                    break;

                case "year":
                    Console.WriteLine("year");
                    break;

                case "new":
                    Console.WriteLine("new");
                    break;

                default:
                    Console.WriteLine("Welcome");
                        break;
                    
            }
        }
    }
}
