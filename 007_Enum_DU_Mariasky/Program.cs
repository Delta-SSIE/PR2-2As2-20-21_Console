using System;

namespace _007_Enum_DU_Mariasky
{
    enum Vyska : byte { sedma = 7, osma, devitka, desitka, spodek, svrsek, kral, eso, filek = svrsek };
    class Program
    {
        static void Main(string[] args)
        {
            Vyska mojeKarta = Vyska.osma;
            Console.WriteLine(mojeKarta);
            mojeKarta++;
            Console.WriteLine(mojeKarta);
            mojeKarta += 5;
            Console.WriteLine(mojeKarta);
            mojeKarta++;
            Console.WriteLine(mojeKarta);

            Vyska karta1 = Vyska.sedma;
            Vyska karta2 = Vyska.devitka;

            if (karta1 > karta2)
                Console.WriteLine("{0} je vyšší než {1}.", karta1, karta2);
            else if (karta1 == karta2)
                Console.WriteLine("Obě karty jsou stejné ({0}).", karta1);
            else
                Console.WriteLine("{1} je vyšší než {0}.", karta1, karta2);

        }
    }
}
