using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class SwitchEO
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter any number to check even or odd: ");
            num = Convert.ToInt32(Console.ReadLine());

            string Result = (num % 2==0) ? " even " : " odd";
            Console.WriteLine("Result" +Result);
        }
    }
}
