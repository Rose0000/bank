using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konto[] konto = new Konto[2];
            konto[0] = new Konto();
            konto[1] = new Konto();

            konto[0].Wlasciciel = new Osoba();
            konto[1].Wlasciciel = new Osoba();

            konto[0].Wlasciciel.Imie = "Jan";
            konto[1].Wlasciciel.Nazwisko = "Kowalski";

            konto[0].Wlasciciel.Imie = "Anna";
            konto[1].Wlasciciel.Nazwisko = "Nowak";

            Console.WriteLine($"Próba zmiany pinu: {konto[0].ZmienPin(1111,0)}");
            Console.WriteLine($"Próba zmiany pinu: {konto[1].ZmienPin(2222, 1111)}");


            Console.ReadLine();
        }
    }
}
