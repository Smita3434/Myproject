using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array
{
    class MergeArray
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 5, 3, 8, 2, 9 };
            int[] b = { 2, 6, 7, 1, 6, 5, 3 };
            int[] c = new int[a.Length + b.Length];

            int k = 0;
            for(int i=0;i<a.Length;i++)
            {
                c[k] = a[i];
                k++;
            }
            for(int i=0;i<b.Length;i++)
            {
                c[k] = b[i];
                k++;
            }
            for(int i=0;i<c.Length;i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }
}
