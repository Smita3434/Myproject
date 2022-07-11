using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.ASSIGNMENT_1
{
    class FrequencyDigit
    {
        static void Main(string[] args)
        {
            long number,temp ,digit,count,i;
            

            Console.WriteLine("Enter any number:");
            number = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Digit \t Frequency");

            for(i=0;i<=9;i++)
            {
                count = 0;
                temp = number;
                while(temp>0)
                {
                    digit = temp % 10;
                    if(digit==i)
                    {
                        count++;
                    }
                    temp = temp / 10;
                }
                if(count>0)
                {
                    Console.WriteLine(i+"\t"+count);
                }
            }
        }
    }
}