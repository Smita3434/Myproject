using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.ASSIGNMENT_1
{
    /*
     WAP in    using switch case for following: Area of a circle. Area of a square
    Area of a right angled triangle. Area of a rectangle Circumference of a circle Perimeter of a square 
    Accept inputs like radius,side,etc through keyboard. 
    //Menu driven program using switch case:
     */
    class Switch_Q5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice");
            Console.WriteLine("1. Area of circle");
            Console.WriteLine("2. Area of square");
            Console.WriteLine("3. Area of right angled triangle");
            Console.WriteLine("4. Area of rectangle ");
            Console.WriteLine("5. Circumference of a circle");
            Console.WriteLine("6.Perimeter of a square");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("enter radius of circle");
                    double r = Convert.ToDouble(Console.ReadLine());
                    double ca = (22 / 7.0) * r * r;
                    Console.WriteLine("Area of circle is="+ca);
                    break;

                case 2:
                    Console.WriteLine("enter side of square");
                    double side = Convert.ToDouble(Console.ReadLine());
                    double sq = side * side;
                    Console.WriteLine("Area of square="+sq);
                    break;

                case 3:
                    Console.WriteLine("enter the base:");
                    double base1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter the height");
                    double height = Convert.ToDouble(Console.ReadLine());

                    double area = 1 / 2 * base1 * height;

                    Console.WriteLine("Area of right angle triangle="+area);

                    break;

                case 4:
                    Console.WriteLine(" enter the lenght");
                    int l = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the width:");
                    int w = Convert.ToInt32(Console.ReadLine());

                    int area1 = l * w;
                    Console.WriteLine("Area of rectangle="+area1);
                    break;

                case 5:
                    Console.WriteLine("Enter the radius");
                    int r1 = Convert.ToInt32(Console.ReadLine());

                    double area2 = 2 * 3.14 * r1;

                    Console.WriteLine("Circumference of a circle="+area2);
                    break;

                case 6:
                    Console.WriteLine("enter the side of square");
                    int side1 = Convert.ToInt32(Console.ReadLine());

                    double p = 4 * side1;

                    Console.WriteLine("Perimeter of Square="+p);
                    break;

            }
            Console.WriteLine("To be Continue Y/N");



        }
    }
}
