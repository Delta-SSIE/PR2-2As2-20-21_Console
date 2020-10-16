using System;

namespace _012_OOP_Obdelnik_s_konstruktorem
{
    class Program
    {
        static void Main(string[] args)
        {
            Obdelnik abcd = new Obdelnik(1, 2);
            Console.WriteLine(abcd.Obsah());
            Console.WriteLine(abcd.Obvod());
            abcd.NastavA(4.5);
            Console.WriteLine($"Obdélník o stranách {abcd.VratA()} a {abcd.VratB()} má obvod {abcd.Obvod()} a obsah {abcd.Obsah()}");

        }
    }
}
