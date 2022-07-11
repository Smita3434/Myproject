using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array.MultiArray
{
    class ArrangeArrayZero
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 6, 0, 6, 0, 3, 7, 0, 0, 1, 9, 5, 0 };
            int count = 0;
            for(int i=0;i<array.Length;i++)
            {
                if(array[i]!=0)
                {
                    array[count++] = array[i];
                }
            }
            for(int i=count;i<array.Length;i++)
            {
                array[i] = 0;
            }
            Console.WriteLine(string.Join(" ",array));
            
        }
    }
}
