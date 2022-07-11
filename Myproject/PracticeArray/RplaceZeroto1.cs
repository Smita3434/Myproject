using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array
{
    class RplaceZeroto1
    {
        static void Main(string[] args)
        {
            int[] array = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            Console.WriteLine(string.Join(" ", array));

            for (int i=0;i<array.Length;i++)
            {
                if(array[i]==0)
                {
                    array[i] = 1;
                }
            }
            Console.WriteLine("....................");
            Console.WriteLine(string.Join(" ",array));
        }
    }
}
