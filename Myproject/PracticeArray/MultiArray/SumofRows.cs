using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array.MultiArray
{
    class SumofRows
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,] { {2,5,7},
                                    {5,7,3},
                                    { 4,7,2}
                                  };

            for (int i = 0; i < a.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    sum = sum + a[i, j];
                }
                Console.WriteLine("sum=" + sum);
                Console.WriteLine();
            }
        }
    }
}
