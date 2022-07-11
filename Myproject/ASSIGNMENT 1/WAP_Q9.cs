using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.ASSIGNMENT_1
{
    /*
      A bank intends to design a program to display the denomination of an input amount. 
      The available denomination with the bank are of rupees 2000, 500, 200, 100, 50, 20, 10 and 1.
      Design a program to accept the amount from the user and display the break-up in descending order of denominations.
    (i.e., preference should be given to the highest denomination available) along with the total number of notes.[Note: Only the denomination used should be displayed].

     */
    class WAP_Q9
    {
        static void Main(string[] args)
        {
            //int r2000 = 0, r500 = 0, r100 = 0, r50 = 0, r20 = 0, r10 = 0, r1 = 0, count = 0;
            Console.WriteLine("Enter the Amount:");
            int amt = Convert.ToInt32(Console.ReadLine());

            if (amt > 99999)
            {
                Console.WriteLine ("Invalid Amount");
            }

           
        }
    }
}
