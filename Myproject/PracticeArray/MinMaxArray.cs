using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array
{
    class MinMaxArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int i, mx, mn, n;

            Console.WriteLine("Input the number of elements to be stored in a elements:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input elements in the array"+n);
            for(i=0;i<n;i++)
            {
                Console.WriteLine("Element"+i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            mx = arr[0];
            mn = arr[0];

            for(i=0;i<n;i++)
            {
                if(arr[i]>mx)
                {
                    mx = arr[i];
                }

                if (arr[i] < mn)
                {
                    mn = arr[i];
                }
            }
            Console.Write("Maximum element is :"+ mx);
            Console.Write("Minimum element is :"+ mn);

        }
    }
}
