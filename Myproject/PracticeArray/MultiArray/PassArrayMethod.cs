using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Array.MultiArray
{
    class PassArrayMethod
    {
        public static void checkPrime(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                bool isPrime = true;
                int n = a[i];

                for (int j = 1; j < n; j++)
                {
                    if (n % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime==true)
                {
                    Console.WriteLine(a[i]+"is Prime ");
                }
            }
            
        }
        public static bool checkArrayPrime(int n)
        {
            bool isPrime = true;
            for (int i=2; i < n;i++)
            {
                if(n%i==0)
                {
                    isPrime = false;
                    break;
                }
            }
            if(isPrime==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 6, 7, 8, 3, 5, 2, 9 };

            for(int i=0;i<a.Length;i++)
            {
                bool isPrimeCheck = PassArrayMethod.checkArrayPrime(a[i]);

                if(isPrimeCheck==true)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
}
