using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.PracticeString
{
    class CountDigits
    {
        
        static void Main(string[] args)
        {
            int count = 0,i=0;
           
            Console.WriteLine("Enter the String:");
            string str = Console.ReadLine();
            int l = str.Length;

            while(i<l)
            {
                if((str[i]>='0') && (str[i]<='9'))
                {
                    count++;
                }
                i++;
            }
            Console.WriteLine("Number of Digits in a string:"+count);
        }
    }
}
