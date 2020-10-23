using System;

namespace _014_OOP_Obdelnik_s_vlastnostmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Obdelnik abcd = new Obdelnik(1, 2);
            Console.WriteLine(abcd.Obsah);
            Console.WriteLine(abcd.Obvod());
            abcd.StranaB = 4.5;
            Console.WriteLine($"Obdélník o stranách {abcd.StranaA} a {abcd.StranaB} má obvod {abcd.Obvod()} a obsah {abcd.Obsah}");


        }
    }
}
