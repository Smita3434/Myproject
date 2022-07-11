using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class SwitchPNZ
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine( "Enter the Number:");
            num = Convert.ToInt32(Console.ReadLine());

            string result = num > 0 ? "Positive" : num < 0 ? "Negative" : "Zero";
            Console.WriteLine(result);
        }
    }
}
