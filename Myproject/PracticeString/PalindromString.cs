using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.PracticeString
{
    class PalindromString
    {
        static void Main(string[] args)
        {
            string str, revs = " ";
            Console.WriteLine(" Enter the  string");
            str = Console.ReadLine();

            for (int i = str.Length - 1; i >= 0; i--)  
            {
                revs=revs+ str[i].ToString();
            }
            if (Equals(str,revs)) // Checking whether string is palindrome or not  
            {
                Console.WriteLine("String is Palindrome"+str+" "+revs);
            }
            else
            {
                Console.WriteLine("String is not Palindrome",str+" "+ revs);
            }
            Console.WriteLine();
        }
    }
}
