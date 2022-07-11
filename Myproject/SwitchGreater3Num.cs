using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class SwitchGreater3Num
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            int max;

            Console.WriteLine("Enter the value num1:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value num2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value num3:");
            num3 = Convert.ToInt32(Console.ReadLine());

            max = (num1 > num2 && num1 > num3) ? num1 : (num2 > num3) ? num2 : num3;

            Console.WriteLine("Greatest Number is"+" "+ max);




        }
        

    }
}
