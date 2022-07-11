using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array
{
    class ReversArrayWithoutTemp
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 22, 33, 44, 55 };

            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine("..................................");


            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
