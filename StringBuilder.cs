using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.PracticeString
{
    class StringBuilder1
    {
        static void Main(string[] args)
        {
            String s = "Hello";
            s = s + "pune";

            StringBuilder sb = new StringBuilder("Hello");
            sb.Append("pune");
            Console.WriteLine(sb);

            sb.Insert(5, "c#");
            Console.WriteLine(sb);
            sb.Replace("Pune", "Program");
            Console.WriteLine(sb);

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Hello");
            sb1.Append("pune");

            Console.WriteLine(sb+" "+sb1);

            StringBuilder sb2 = new StringBuilder("India",60);

            for(int i=0;i<sb.Length;i++)
            {
                Console.WriteLine(sb[i]);
            }
            Console.WriteLine(sb.Equals(sb1));
            Console.WriteLine(sb == sb1) ;

            String str = sb.ToString();
            String str1 = sb1.ToString();

            Console.WriteLine(str.CompareTo(str1));
        }
    }
}
