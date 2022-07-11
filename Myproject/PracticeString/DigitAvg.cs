using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.PracticeString
{
    class DigitAvg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            String str = Console.ReadLine();

            Console.WriteLine(str);
            int count = 0;
            int sum = 0;
            int symbole = 0;
            int alpha = 0;
            for(int i=0;i<str.Length;i++)
            {
                if(Char.IsLetter(str[i]))//if((str[i]>='a' && str[i]<='z')||(str[i]>='A' && str[i]<='Z'))
                {
                    alpha++;
                }
                else if(str[i]>='0' && str[i]<='9')
                {
                    count++;
                    //int x=(int)(Char.GetNumericValue(str[i]));

                    int x = int.Parse(str[i].ToString());
                    sum = sum + x;
                }
                else
                {
                    symbole++;
                }
            }
            Console.WriteLine("Number of digits="+count);
            Console.WriteLine("sum of digit="+sum);
            Console.WriteLine("Number of alphabets="+alpha);
            Console.WriteLine("Number of symbole="+symbole);

            int avg = sum / count;
            Console.WriteLine("Average="+avg);

        }
    }
}
