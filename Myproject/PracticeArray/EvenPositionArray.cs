using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array
{
    class EvenPositionArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 7, 2, 8, 6 };

            Console.WriteLine("Elements of given array present on even position:");

            for (int i = 1; i < arr.Length; i = i + 2)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
