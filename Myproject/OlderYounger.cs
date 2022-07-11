using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    //Write a program to input Number of older and younger siblings only
    //child if person has no siblings
    //oldest child if the person only has younger siblings
    //youngest child if the person only has older siblings
    //middle child if the person has both younger and older siblings

    class OlderYounger
    {
        static void Main(string[] args)
        {
            int old, young;
            Console.WriteLine("Enter the number of older sibling");
            old = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter  the number of Younger sibling");
            young = Convert.ToInt32(Console.ReadLine());

            if( old == 0 && young == 0)
            {
                Console.WriteLine("You are Single child");
            }
            else if( old == 0 && young > 0 )
            {
                Console.WriteLine("You are Oldest child");
            }
            else if (young == 0 && old > 0)
            {
                Console.WriteLine("You are Youngest child");
            }
            else if (old == young)
            {
                Console.WriteLine("You are Middle child");
            }
            else
            {
                Console.WriteLine("you enter the wrong number");
            }
        }
    }
}
