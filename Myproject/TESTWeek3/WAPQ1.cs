using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TESTWeek3
{
    //create a Array of integer and count the number of even  and odd elements from array.
    class WAPQ1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            
            int even = 0, odd = 0;
            Console.WriteLine("Enter the array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("----------------------------------------");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("Even  :" + even);
            Console.WriteLine("Odd  :" + odd);
        }
    }
}