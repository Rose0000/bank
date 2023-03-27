using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Punkt
{
    class Punkt
    {
        public double X = 0, Y = 0;
        // konstruktor
        public Punkt(double x, double y) 
        { 
            this.X = x;
            this.Y = y;
        }

        // metoda obliczjąca odległośc między dwoma punkami
        public double distance(Punkt p)
        {
            return Math.Sqrt((this.X - p.X) * (this.X - p.X) + (this.Y - p.Y) * (this.Y - p.Y));
        }

        // nadpisuję metoę ToString
        public override string ToString()
        {
            return $"({this.X} , {this.Y})";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt p1 = new Punkt(0, 0);
            Punkt p2 = new Punkt(1, 1);
            Console.WriteLine($"[{p1},{p2}] {p1.distance(p2)}");

            Console.ReadLine();


        }
    }
}
