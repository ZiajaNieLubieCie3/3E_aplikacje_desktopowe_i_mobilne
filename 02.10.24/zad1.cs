using System;
using System.Data;
using System.Runtime.CompilerServices;

public class program
{
     
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj x");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Podaj y");
        double y = Convert.ToDouble(Console.ReadLine());

        string cwiartka;

        if (x > 0 && y > 0)
        {
            cwiartka = ("lewa gorny");
        }
        else if (x > 0 && y > 0)
        {
            cwiartka = ("prawy gorny");
        }
        else if (x < 0 && y < 0)
        {
            cwiartka = ("lewy dol");

        }
        else if (x > 0 && y < 0)
        {
            cwiartka = ("prawy dol");
        }
       else
        {
            cwiartka = "Linia wykresu";
        }
        
        
        Console.WriteLine(cwiartka);
    }
}
