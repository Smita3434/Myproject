using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array
{
    class ReverseCharArray
    {
        static void Main(string[] args)
        {
            char[] letters = { 'y', 'r', 'w', 't' };

            for(int i=letters.Length-1;i>=0;i--)
            {
                Console.WriteLine(letters[i]);
            }
        }
    }
}
