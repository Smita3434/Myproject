using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class Average
    {
        static void Main(string[] args)
        {
            double rl;
            string nm;
            double sub1, sub2, sub3, sub4, sub5;
            double total, average, percentage;

            Console.WriteLine("Enter the RollNo of Student:");
            rl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the name of Student:");
            nm = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the marks of sub1:");
            sub1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of sub2:");
            sub2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of sub3:");
            sub3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of sub4:");
            sub4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of sub5:");
            sub5 = Convert.ToInt32(Console.ReadLine());

            total = sub1 + sub2 + sub3 + sub4 + sub5;
            percentage = (total / 500.0)*100;
            average = total / 5.0;

            Console.WriteLine("\nRoll No: {0}\nName of Student: {1}\n",rl,nm);
            Console.WriteLine( "Total Marks ={0}\nPercentage={1}\nAverage={2}",total,percentage,average);

        }
    }
}
