using System;
namespace Zadanie8
{
    class Zadanie8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe, 1 konczy dzialanie");
            int liczba = Convert.ToInt32(Console.ReadLine());
            int wynik = 1;
            while(liczba != 1)
            {
                wynik *= liczba;
                Console.WriteLine("Podaj kolejna liczbe: ");
                liczba = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Wynik to: " + wynik);
        }
    }
}