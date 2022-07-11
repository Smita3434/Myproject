using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array
{
    class ArrayCharMax
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'r', 't', 'e' };

            char max = ch[0];

            for(int i=0;i<ch.Length;i++)
            {
                if(max<ch[i])
                {
                    max = ch[i];
                }
            }

            Console.WriteLine("Max is="+max);
        }
    }
}
