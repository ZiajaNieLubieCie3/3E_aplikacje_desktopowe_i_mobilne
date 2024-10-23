using System;
namespace Zadanie9
{
    class Zadanie9
    {
        public static void Main(string[] args)
        {
            int i = 3;
            Console.WriteLine("Podaj element ciagu fibbonaciego");
            int n = Convert.ToInt32(Console.ReadLine());
            int fib = 1;
            int fibO = 1;
            int FibC;
            if (n > 2)
            {
                Console.WriteLine(fib);
                Console.WriteLine(fibO);
            }
            if (n == 1)
            {
                Console.WriteLine(fib);
            }
            else if (n == 2)
            {
                Console.WriteLine(fib);
                Console.WriteLine(fib);
            }
            while (i <= n)
            {
                // 1 2 3 4 5 6 7  8  9  10
                // 1 1 2 3 5 8 13 21 34 55
               
                FibC = fib + fibO;
                fibO = fib;
                fib = FibC;
                Console.WriteLine(FibC);
                i++;
            }
            
        }
    }
}