using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.PracticeString
{
    class TrimMethod
    {
        static void Main(string[] args)
        {
            string s1 = "Hello c#";
            string s2 = s1.Trim();
            char[] ch = { '#' };
            char[] ch1 = { 'H' };
           string s3 = s1.TrimEnd(ch);
            string s4 = s1.TrimStart(ch);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
        }
    }
}
