using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array.MultiArray
{
    class LowerTraingle
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[50, 50];
            Console.WriteLine("Display the lower triangular of a given matrix");
            Console.WriteLine("..............................................");

            Console.Write("Input the size of the matrix : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input elements in the first matrix :\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The matrix is :\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(" "+arr1[i, j]);
                Console.Write("\n");
            }
            Console.WriteLine("............................");

            Console.Write(" lower triangular matrix");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < n; j++)
                    if (i <= j)
                        Console.Write("  " + arr1[i, j]);
                    else
                        Console.Write("  " );

            }
        }
    }
}
