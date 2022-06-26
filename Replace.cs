using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.PracticeString
{
    class Replace
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            string replaceVowels=" ";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'A' || str[i] == 'e' || str[i] == 'E' || str[i] == 'i' || str[i] == 'I' ||
                    str[i] == 'o' || str[i] == 'O' || str[i] == 'u' || str[i] == 'U')
                {
                    replaceVowels = str.Replace(str[i], '#');
                   
                }
                
            }
            Console.WriteLine(replaceVowels);

        }
    }
}
