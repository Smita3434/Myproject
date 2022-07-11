using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.PracticeString
{
    class CountVowels
    {
        static void Main(string[] args)
        {
            int  count = 0;
            Console.WriteLine("Input String");
            string s = Console.ReadLine();

            for(int i=0;i<s.Length;i++)
            {
                if (s[i] == 'a' || s[i] == 'A' || s[i] == 'e' || s[i] == 'E' || s[i] == 'i' || s[i] == 'I' || 
                    s[i] == 'o' || s[i] == 'O' || s[i] == 'u' || s[i] == 'U')
                    count++;
                
            }
            Console.WriteLine("Number of vowels in string:" + count);
        }
    }
}
