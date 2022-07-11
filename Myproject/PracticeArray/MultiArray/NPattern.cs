using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array.MultiArray
{
    class NPattern
    {
        static void Main(string[] args)
        {


            int[,] array = new int[3, 3] {{1,2,3},
                                      {4,5,6},
                                      {7,8,9},
       
                                     };


            for(int i=0;i<array.GetLength(0);i++)
            {
                for(int j=0;j<array.GetLength(1);j++)
                {
                    if(j==0 || j==array.GetUpperBound(1) || i==j)
                    {
                        Console.Write(array[i,j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
  
                }
                Console.WriteLine();
            }

        }

    }
}
