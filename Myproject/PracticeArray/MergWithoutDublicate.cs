using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array
{
    class MergWithoutDublicate
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 6, 3, 6, 7, 8, 2, };
            int[] arr1 = { 6, 9, 8, 4, 6, 2, 4, };

            Console.WriteLine("Array first Element is:");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Array of Second element is:");
            for(int i=0;i<arr1.Length;i++)
            {
                Console.WriteLine(arr1[i]);
            }

            int[] arr2 = new int[arr.Length + arr1.Length];
            int k = 0;

            for(int i=0;i<arr.Length;i++)
            {
                bool isVisited = false;
                int count = 1;
                for(int j=i-1;j>=0;j--)
                {
                    if(arr[i]==arr[j])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if(isVisited==false)
                {
                    for(int m=i+1;m<arr1.Length;m++)
                    {
                        if(arr[i]==arr[m])
                        {
                            count++;
                        }
                    }
                    if(count==1)
                    {
                        arr2[k] = arr[i];
                        k++;
                    }
                }
            }
            for(int i=0;i<arr1.Length;i++)
            {
                bool isvisit = false;
                int count = 1;

                for(int j=i-1;j>=0;j--)
                {
                    if(arr1[i]==arr1[j])
                    {
                        isvisit = true;
                        break;
                    }
                }
                if(isvisit==false)
                {
                    for(int m=i+1;m<arr1.Length;i++)
                    {
                        if(arr1[i]==arr1[m])
                        {
                            count++;
                        }
                    }
                    if(count==1)
                    {
                        arr2[k] = arr1[i];
                        k++;
                    }
                }
            }
            Console.WriteLine("............................");
            Console.WriteLine("elements of merge array with only unique elements");
            for(int i=0;i<k;i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}
