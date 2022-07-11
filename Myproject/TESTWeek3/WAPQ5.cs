using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TESTWeek3
{
    class WAPQ5
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 0, 7, 0, 8, 0, 3 };
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    array[count++] = array[i];
                }
            }
            for (int i = count; i < array.Length; i++)
            {
                array[i] = 0;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
