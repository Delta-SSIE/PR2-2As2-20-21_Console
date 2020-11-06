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

            //if (ucet.Vyber(70))
            //{
            //    Console.WriteLine("Vybráno");
            //}
            //else
            //{
            //    Console.WriteLine("Tolik na účtu není.");
            //}
            //Console.WriteLine($"Na účtu je {ucet.Zustatek} Kč.");

            //double castka = 70;
            //while (ucet.Vyber(castka))
            //{
            //    Console.WriteLine($"Vybráno {castka} Kč, zbývá {ucet.Zustatek}");
            //}

            //Console.WriteLine("Došly prachy.");

            for (int i = 0; i < 10; i++)
            {
                ucet.Urokuj(1.7);
                Console.WriteLine("Na účtu je {0:0.00} Kč.", ucet.Zustatek);
            }

            
            Ucet ucet2 = new Ucet("Pepa");
            double vklad = 1;
            double urokovaMira = 1.7;
            ucet2.Uloz(vklad);
            

            int obdobi = 0;
            
            while (ucet2.Zustatek < 2 * vklad)
            {
                ucet2.Urokuj(urokovaMira);
                obdobi++;
            }

            Console.WriteLine($"Zdvojnásobí se za {obdobi} období.");

        }
    }
}
