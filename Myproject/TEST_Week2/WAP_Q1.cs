using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TEST_Week2
{
    //1.	WAP to accept mobile number and count frequency of digit
    class WAP_Q1
    {
        static void Main(string[] args)
        {
            long number, temp, digit, count, i;


            Console.WriteLine("Enter mobile number:");
            number = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Digit \t Frequency");

            for (i = 0; i <= 9; i++)
            {
                count = 0;
                temp = number;
                while (temp > 0)
                {
                    digit = temp % 10;
                    if (digit == i)
                    {
                        count++;
                    }
                    temp = temp / 10;
                }
                if (count > 0)
                {
                    Console.WriteLine(i + "\t" + count);
                }
            }
        }
    }
}
