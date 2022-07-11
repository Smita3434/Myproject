using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.PracticeString
{
    class ReversStringBuilder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string name = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            for (int i = name.Length - 1; i >= 0; i--)
            {
                sb.Append(name[i]);
            }
            string newName = sb.ToString();

            Console.WriteLine(newName);
        }

    }
}
