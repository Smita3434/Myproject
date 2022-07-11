using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array.MultiArray
{
    class FascinatingNumber
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            String newNum = " ";
            for (int i = 1; i < 3; i++)
            {
                newNum = newNum + (num * i);
            }
            Console.WriteLine(newNum);
            for (int i = 0; i < newNum.Length; i++)
            {
                int count = 1;

                bool isVisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (newNum[i] == newNum[k])
                    {
                        isVisited = true;
                    }
                }
                if (isVisited == false)
                {
                    for (int j = i + 1; j < newNum.Length; j++)
                    {
                        if (newNum[i] == newNum[j])
                        {
                            count++;

                        }
                    }
                    //if (count > 1) //dublicate element
                }
                if (count == 1)
                {
                    Console.WriteLine("Fascinating number");
                }
                else
                {
                    Console.WriteLine("Not fascinating number");
                }

            }

        }
    }
}