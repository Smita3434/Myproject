using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array
{
    class SearchingCount
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 8, 9, 3, 6 };

            Console.WriteLine("Enter Element for Searching");

            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            
            for(int i=0;i<a.Length;i++)
            {
                if(num==a[i])
                {
                    count++;
                }
            }
            if(count==1)
            {
                Console.WriteLine("Number is present");
            }
            else
            {
                Console.WriteLine("Number is not Present");
            }
        }
    }
}
