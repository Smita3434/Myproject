using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array.MultiArray
{
    class MaximunRows
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,] { {2,5,7},
                                    {5,7,3},
                                    { 4,7,2}
                                  };

            for (int i = 0; i < a.GetLength(0); i++)
            {
                int max = a[i, 0];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (max < a[i, j])
                    {
                        max = a[i, j];
                    }
                }
                Console.WriteLine("Max=" + max);
            }

        }
    }
}
