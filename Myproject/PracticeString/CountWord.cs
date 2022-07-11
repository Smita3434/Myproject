using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.PracticeString
{
    class CountWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            String str = Console.ReadLine();

            string[] words = str.Split(" ");

            for(int i=0;i<str.Length;i++)
            {
                int count = 1;
                bool isVisited = false;

                for(int k=i-1;k>=0;k--)
                {
                    if(words[i]==words[k])
                    {
                        isVisited = true;
                        break;
                    }

                }
                if(isVisited==false)
                {
                    for(int j=i+1;j<words.Length;j++)
                    {
                        if(words[i]==words[j])
                        {
                            count++;
                        }
                    }
                    //if(count>1) dublicate word logic
                    if(count==1)
                    {
                        Console.WriteLine(words[i]+" "+count);
                    }
                }
            }
        }
    }
        
}
