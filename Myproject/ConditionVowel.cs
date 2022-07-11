using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class ConditionVowel
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine()[0]);

            if ((ch >= 'a' && ch <= 'A') || (ch >= 'e' && ch <= 'E') || (ch >= 'i' && ch <= 'I') || (ch >= 'o' && ch <= 'O') || (ch >= 'u' && ch <= 'U'))
            {
                Console.WriteLine( "Vowel ");
            }
            else
            {
                Console.WriteLine("Consonent");
            }
        }
    }
}
