using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // First Part
            int a = 0;

            PrintPrimeOrNot(CheckNumBetw_0_1000(a));

            // Second Part

            int b = 0;
            int c = 0;

            a = CheckNumBetw_0_1000(a);
            b = CheckNumBetw_0_1000(b);
            c = CheckNumBetw_0_1000(c);

//            (PrimeOrNot(a) && PrimeOrNot(b) && PrimeOrNot(c)) ? (Console.WriteLine($"={a + b + c} = {a} + {b} + {c}")) : Console.WriteLine("Not Primary Numbers")
         if (PrimeOrNot(a) && PrimeOrNot(b) && PrimeOrNot(c))
            {
                Console.WriteLine($"{a + b + c} = {a} + {b} + {c}");
            }
            else
            {
                Console.WriteLine("Not Primary Numbers");
            }

 


        }

        private static bool PrimeOrNot(int a)
        {
            bool isPrime;
            int m = 2;
            while (a % m != 0)
            {
                m++;
            }

            if (m < a)
            {
                isPrime = false;
            }
            else
            {
                isPrime = true;
            }

            return isPrime;
        }

        private static int PrintPrimeOrNot(int a)
        {
            // check if number is prime?
            int m = 2;
            while (a % m != 0)
            {
                m++;
            }

            if (m < a)
            {
                Console.WriteLine($"{a} is NOT prime");
            }
            else
            {
                Console.WriteLine($"{a} is prime indeed");
            }
            return a;
        }

        private static int CheckNumBetw_0_1000(int a)
        {
            
            do
            {
                Console.WriteLine("Please Write Number between 0 and 1000");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a <= 0 || a >= 1000);
            return a;
        }
    }
}
