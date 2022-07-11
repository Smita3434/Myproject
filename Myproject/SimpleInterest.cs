using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class SimpleInterest
    {
        static void Main(string[] args)
        {
            
            double P, SI, R, T;

            Console.WriteLine("Enter the loan amount:");
            P = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of year:");
            T = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the rate of interest:");
            R = double.Parse(Console.ReadLine());

            SI = (P * R * T) / 100;

            Console.WriteLine("Simple Interest:"+SI+"\n");
        }
    }
}
