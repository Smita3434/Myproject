using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.PracticeString
{
    class CountOcurrsWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();

            Console.WriteLine("enter the word:");
            string word = Console.ReadLine();

            string[] a = str.Split(' ');
            int count = 0;

            for(int i=0;i<a.Length;i++)
            {
                if(word.Equals(a[i]))
                {
                    count++;
                }
            }
            Console.WriteLine("words occurrence "+ count + "times");
        }
    }
}
