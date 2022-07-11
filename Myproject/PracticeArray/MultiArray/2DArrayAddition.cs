using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array.MultiArray
{
    class _2DArrayAddition
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            int[,] b =new int [2, 2];
            int[,] c = new int[2, 2];

            Console.WriteLine("Enter the First and second Matrix");

            Console.WriteLine("First Matrix");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Second Matrix");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("First and Second Matrix is");
           
            //Caluculating

            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<b.GetLength(1);j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    
                }
            }
            Console.WriteLine("Addition of Matrix is");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write("\n");
                for (int j = 0; j < b.GetLength(1); j++)
                    Console.Write(c[i, j] +" ");
            }

        }
    }
}
