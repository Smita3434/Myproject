using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    // Write a program to input your age and your friends age and print Hi if friends Age<your age.print good morning  your age> friends age otherwise print How are you?

    class Age
    {
        static void Main(string[] args)
        {
            int myage , fage;
            Console.WriteLine("Enter the My age:");
            myage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the my friend age:");
            fage = Convert.ToInt32(Console.ReadLine());

            if(fage < myage)
            {
                Console.WriteLine("Hi");
            }
            else if( myage > fage)
            {
                Console.WriteLine("Good Morning");
            }
            else
            {
                Console.WriteLine("How are you?");
            }


        }
    }
}
