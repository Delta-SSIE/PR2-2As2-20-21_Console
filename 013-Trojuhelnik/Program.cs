using System;

namespace _013_Trojuhelnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Trojuhelnik abc = new Trojuhelnik(1, 1, 5);
            Console.WriteLine($"Trojúhelník o stranách {abc.VratA()}, {abc.VratB()}, {abc.VratC()} má obvod {abc.Obvod()} a obsah {abc.Obsah()}.");
        }
    }
}
