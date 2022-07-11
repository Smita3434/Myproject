using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array
{
    class UniqueElements
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 6, 7, 2, 4, 8, 9, 0, 7, 8, 1, 6, 8, 9, 5 };
            for(int i=0;i<a.Length;i++)
            {
                int count = 1;

                bool isVisited = false;
                for(int k=i-1;k>=0;k--)
                {
                    if(a[i]==a[k])
                    {
                        isVisited = true;
                    }
                }
                if(isVisited==false)
                {
                    for(int j=i+1;j<a.Length;j++)
                    {
                        if(a[i]==a[j])
                        {
                            count++;
                            
                        }
                    }
                    if(count>1) //dublicate element
                    //if(count==1)
                    {
                        Console.WriteLine(a[i]+" "+" "+count);
                    }
                }
            }
        }
    }
}