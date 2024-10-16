using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadanie 1
            /*
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            //Zadanie 2
            /*
            for(int i = 100; i >= 50; i--)
            {
                Console.WriteLine(i);
            }
            */


            // Zadanie 3
            /*
            double suma = 0;
            int podanaLiczba = 1;
            int i;

            for (i = 0; podanaLiczba != 0; i++)
            {
                podanaLiczba = Convert.ToInt32(Console.ReadLine());
                suma += podanaLiczba;
            }
            Console.WriteLine("Suma: " + suma + ", liczba wprowadzonych liczb: " + (i - 1));
            */


            // Zadanie 4

            /*
            int pierwszaLiczba = Convert.ToInt32(Console.ReadLine());
            int drugaLiczba = Convert.ToInt32(Console.ReadLine());

            if (pierwszaLiczba > drugaLiczba)
            {
                drugaLiczba = pierwszaLiczba;
            }

            for(int i = pierwszaLiczba; i <= drugaLiczba; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            */

            // Zadanie 5
            /*
            int liczba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToString(liczba, 2));
            */

            //Zadanie 6

            int wysokoscTrojkata = Convert.ToInt32(Console.ReadLine());

            for (int i = wysokoscTrojkata; i > 0; i--)
            {
                for (int y = i; y > 1; y--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }




        }
    }
}