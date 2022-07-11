using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.PracticeString
{
    class ReverseWordFirstLast
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            String s = Console.ReadLine();

            String[] str = s.Split(" ");

            String reversword = " ";

            for(int i=0;i<str.Length-1;i++)
            {
                String word = str[i];
                String revers = " ";

                for(int j=word.Length-1;j>=0;j--)
                {
                    revers = revers + word[j];
                }
                reversword = reversword + revers + " ";
            }
            Console.WriteLine(reversword);

            Console.WriteLine(str[0]+" "+reversword+" "+str[str.Length-1]);
        }
    }
}
