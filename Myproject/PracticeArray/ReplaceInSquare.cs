using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array
{
    class ReplaceInSquare
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int i,n;

            Console.WriteLine("Input the number of elements to be stored in a elements:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input elements in the array:" + n);
            for (i = 0; i <n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Replace in Square");
            for ( i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i] * arr[i];
                }
                Console.WriteLine(arr[i]);
            }
        }
    }
}
