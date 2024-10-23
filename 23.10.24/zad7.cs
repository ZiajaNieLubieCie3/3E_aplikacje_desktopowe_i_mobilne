using System;
namespace Zadanie7
{
    class Zadanie7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj ilosc liczb: ");
            int Ilosc = Convert.ToInt32(Console.ReadLine());
            int wynik = 0;
            int i = Ilosc;
            while(i > 0)
            {
                Console.WriteLine("Podaj liczbe: ");
                int liczba = Convert.ToInt32(Console.ReadLine());
                wynik += liczba;
                i--;
            }
            Console.WriteLine("Srednia tych liczb to: " + wynik / Ilosc);
        }
    }
}