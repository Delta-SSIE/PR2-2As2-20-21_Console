using System;

namespace _016_OOP_Ucet
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucet ucet = new Ucet("Franta");
            Console.WriteLine($"Na účtu je {ucet.Zustatek} Kč.");

            ucet.Uloz(1000);
            Console.WriteLine($"Na účtu je {ucet.Zustatek} Kč.");

            if (ucet.Vyber(70))
            {
                Console.WriteLine("Vybráno");
            }
            else
            {
                Console.WriteLine("Tolik na účtu není.");
            }
            Console.WriteLine($"Na účtu je {ucet.Zustatek} Kč.");

            double castka = 70;
            while (ucet.Vyber(castka))
            {
                Console.WriteLine($"Vybráno {castka} Kč, zbývá {ucet.Zustatek}");
            }

            Console.WriteLine("Došly prachy.");

        }
    }
}
