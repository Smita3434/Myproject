using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array.MultiArray
{
    class _2DarrayDemo
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            Console.WriteLine("Enter the  array Elements:");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine(".................................");

            for(int i=0;i<a.GetLength(0);i++)
            {
                for (int j = 0; j < a.GetLength(1);j++) 
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(".....................");

            foreach(int i in a)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            Console.WriteLine("......................");

            for(int i=0;i<a.GetUpperBound(0);i++)
            {
                for(int j=0;j<a.GetUpperBound(1);j++)
                {
                    Console.WriteLine(a[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("..........................");


            for (int i = 0; i < a.GetLowerBound(0); i++)
            {
                for (int j = 0; j < a.GetLowerBound(1); j++)
                {
                    Console.WriteLine(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
