using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    // Write a program to input age of a person and print if he/she is teenager or not
    class Teenager
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Enter the age of person:");
            age = Convert.ToInt32(Console.ReadLine());

             if (age >= 13 && age <= 19)
            {
                Console.WriteLine(" The person is Teenage");
            }
             else
            {
                Console.WriteLine("The person is  Not Teenage");
            }


        }
    }
}
