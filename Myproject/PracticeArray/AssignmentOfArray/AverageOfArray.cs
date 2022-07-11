using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array.AssignmentOfArray
{
    //WAP to accept the dimension of the 1D array and create and accept data in that array.
    //Calculate the average value of array elements.
    class AverageOfArray
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int i, n, sum = 0;
            float avg=0.0f;


            Console.Write("\n\nFind average of all elements of array:\n");
            Console.Write("--------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum=sum+ a[i];
                avg = sum / n;
            }

            Console.Write("Average of all elements stored in the array is :"+avg);
        }
    }
}
