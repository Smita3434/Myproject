using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Practice
{
    class KrishnMurti
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;

            int sum = 0;
            while (num > 0)
            {
                int n = num % 10;
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                num = num / 10;
            }
            num = temp;

            if (num == sum)
            {
                Console.WriteLine("Number is Krishnmurti");
            }
            else
            {
                Console.WriteLine("Number is not Krishnmurti");
            }

        }
    }
    class Neon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int sq = num * num;
            int sum = 0;

            while(sq!=0)
            {
                sum =sum+ sq % 10;
                sq = sq / 10;
            }

            if(sum==num)
            {
                Console.WriteLine("Neon");
            }
            else
            {
                Console.WriteLine("Not Neon");
            }
        }
    }
    class Three
    {
        static void Main(string[] args)
        {
            long num;
            int count = 0;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt64(Console.ReadLine());

            do
            {
                num = num / 10;
                count++;

            } while (num != 0);
            Console.WriteLine("Number of digit:" + count);
        }
    }
    class Two
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number:");
            num = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;
            int sum = 0;
           while(num>0)
            {
                int last = num % 10;
                sum = sum + last;
                num = num / 10;
                if (last%2==0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("Even:"+even);
            Console.WriteLine("Odd:"+odd);

        }
    }
    class One
    {
        static void Main(string[] args)
        {
            int n = 534;
            int sum = 0;
            while(n>0)
            {
                int last = n % 10;
                sum = sum + last;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
    class Lcm
    {
        static void Main(string[] args)
        {
            int a = 12, b = 18;
            int gcd = 0;

            for(int i=0;i<a;i++)
            {
                if(a%i==0 && b%i==0)
                {
                    gcd = i;
                }
            }
            Console.WriteLine("gcd="+gcd);
            int lcm = a * b / gcd;

            Console.WriteLine("lcm="+lcm);
        }
    }
    class Odd300To200
    {
        static void Main(string[] args)
        {
            for (int i = 300; i >= 200; i--)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }

           // Console.WriteLine(".........................");

            /*for(int i=299;i>=200;i=i-2)
            {
                Console.WriteLine(i);
            }*/
        }
    }

    class SeriesMult
    {
        static void Main(string[] args)
        {
            
            for(int i=4;i<=40;i=i+4)
            {
               
                Console.WriteLine(i);

            }
            
        }
    }

    class SeriesSq
    {
        static void Main(string[] args)
        {
            
            for(int i=1;i<=10;i++)
            {
                int sq = i * i;
                Console.WriteLine(sq);
            }
        }
    }
    class TablePrint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine(n+"*"+i+"="+n*i);
            }
        }
    }
    
    class Factorial
    {
        static void Main(string[] args)
        {
            int mult = 1;
            for(int i=1;i<=10;i++)
            {
                mult = mult * i;
               // Console.WriteLine(mult);
            }
           Console.WriteLine(mult);
        }
    }

    class fact
    {
        static void Main(string[] args)
        {
            int num, fact = 1;
            Console.WriteLine("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial is:" + fact);
        }
    }

    class Factors
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());

            for(int i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Prime
    {
        static void Main(string[] args)
        {
            int num;
            int count = 0;
            Console.WriteLine("enter the number:");
            num = int.Parse(Console.ReadLine());

            for(int i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine("Factor:"+i);
                    count++;
                }
            }
            Console.WriteLine("Count:"+count);

            if (count == 2)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }

        }
    }
}
