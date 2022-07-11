using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array
{
    class ArrayEvenOdd
    {
        static void Main(string[] args)
        {
            int[] a = { 6, 9, 4, 13, 2, 8, 5 };

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine("Even Number:" + a[i]);
                }
            }
            
            for (int i=0;i<a.Length;i++)
            { 
                if(a[i]%2!=0)
                {
                    Console.WriteLine("Odd Number:"+a[i]);
                }
            }
        }
    }
}
