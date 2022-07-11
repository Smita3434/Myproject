using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array
{
    class SumOfIntArray
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int n, sum = 0;

            Console.WriteLine("Input the number of elements:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input element in the array"+n);
            for(int i=0; i<n;i++)
            {
                Console.WriteLine("element :"+i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<n;i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("Sum of elements stored in the array is:"+sum);
        }
    }
}
