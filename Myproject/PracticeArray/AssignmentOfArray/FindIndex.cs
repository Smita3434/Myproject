using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array.AssignmentOfArray
{
    
    class FindIndex
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 6, 8, 2, 5, 8 };
            int index = 0;

           foreach(int value in a)
            {
                Console.WriteLine($"{index}:{value}");
                index++;
            }
        }
    }
}
