using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array
{
    class SearchinBool
    {
        static void Main(string[] args)
        {
            int[] a = { 6, 4, 8, 2, 7, 9 };
            Console.WriteLine("Enter the element for searching");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isPresent = false;

            
            for(int i=0;i<a.Length;i++)
            {
                if(num==a[i])
                {
                    isPresent = true;
                    break;
                }

            }
            if(isPresent==true)
            {
                Console.WriteLine("number is present");
            }
            else
            {
                Console.WriteLine("number is not present");
            }
        }
    }
}
