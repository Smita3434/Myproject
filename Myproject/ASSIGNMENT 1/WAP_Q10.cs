using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.ASSIGNMENT_1
{
    class WAP_Q10
    {
        /*
         Write a program to input basic salary of an employee and calculate its Gross salary according to following:
           Basic Salary <= 10000 : HRA = 20%, DA = 80% 
            Basic Salary <= 20000 : HRA = 25%, DA = 90% 
            Basic Salary >20000 : HRA = 30%, DA = 95% */

        
        static void Main(string[] args)
        {
            float gross, da, hra;
            int basic;

            Console.WriteLine("Enter basic salary of an employee:");
            basic = Convert.ToInt32(Console.ReadLine());

            if(basic<=10000)
            {
                da = basic * 0.8f;
                hra = basic * 0.2f;
            }
            else if (basic <= 20000)
            {
                da = basic * 0.9f;
                hra = basic * 0.25f;
            }
            else
            {
                da = basic * 0.95f;
                hra = basic * 0.3f;
            }

            gross = basic + hra + da;
            Console.WriteLine("GROSS SALARY OF EMPLOYEE="+gross);
        }
    }
}
