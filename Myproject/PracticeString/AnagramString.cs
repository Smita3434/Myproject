using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.PracticeString
{
    class AnagramString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st String:");
            String str1 = Console.ReadLine();
            Console.WriteLine("Enter the 2nd String:");
            String str2 = Console.ReadLine();

            String s1 = str2.ToLower();
            String s2 = str2.ToLower();

            char[] ch1 = s1.ToCharArray();
            char[] ch2 = s2.ToCharArray();

           // Array.Sort(ch1);
           // Array.Sort(ch2);

            Console.WriteLine(String.Join(" ",ch1));
            Console.WriteLine(String.Join(" ",ch2));

            String st1 = new String(ch1);
            String st2 = new String(ch2);

            if(st1.CompareTo(st2)==0)
            {
                
                Console.WriteLine("Both string are Anagram");
            }
            else
            {
                Console.WriteLine("Both string are not Anagram");
            }
        }
    }
}
