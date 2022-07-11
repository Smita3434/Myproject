using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.PracticeString
{
    class PatternString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            String str = Console.ReadLine();

            for(int i=0;i<str.Length;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write(str[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
