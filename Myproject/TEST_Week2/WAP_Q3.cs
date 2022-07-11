using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TEST_Week2
{
    // WAP to given number is kaprekar number or not
    class WAP_Q3
    {
        static void Main(string[] args)
        {
            int i, d = 0, a, s = 0, f, l;

            Console.WriteLine("Enter the Integer:");
            a = Convert.ToInt32(Console.ReadLine());

            for(i=a;i>0;i=i/10)
            {
                d++;
            }
            s = a * a;
            f = s / (int)Math.Pow(10, d);
            l = s % (int)Math.Pow(10, d);
            if(f+l==0)
            {
                Console.WriteLine("Kaprekar Number");
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
