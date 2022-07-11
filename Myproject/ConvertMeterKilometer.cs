using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class ConvertMeterKilometer
    {
        static void Main(string[] args)
        {
            double km, m;
            double cm;

            Console.WriteLine("Enter length in centimeter:");
            cm =Convert.ToInt32(Console.ReadLine());

            m = cm / 100.0;
            km = cm / 10000.0;

            Console.WriteLine("length in meter:" + m);
            Console.WriteLine("length in kilometer:" + km);
        }
    }
}
