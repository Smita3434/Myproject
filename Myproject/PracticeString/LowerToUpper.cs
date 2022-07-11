using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.PracticeString
{
    class LowerToUpper
    {
        static void Main(string[] args)
        { 
            Console.WriteLine(" Enter the string");
            String str = Console.ReadLine();

            //string s = str.ToLower();
            //Console.WriteLine(s);
            String lower = " ";
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]>='A' && str[i]<='Z')
                {
                    lower = lower + (char)(str[i] + 32);
                }
                else
                {
                    lower = lower + str[i];
                }
            }
            Console.WriteLine(lower);
        }
    }
}
