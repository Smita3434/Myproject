using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class BloodDonation
    {
        static void Main(string[] args)
        {
            int age, weight;

            Console.WriteLine("Enter the age:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the weight:");
            weight = Convert.ToInt32(Console.ReadLine());

            if(age>18 && weight>50)
            {
                Console.WriteLine("Eligibale for blood donation");
            }
            else
            {
                Console.WriteLine("not eligibale for blood donation");
            }
        }
    }
}
