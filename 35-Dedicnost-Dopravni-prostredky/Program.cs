using System;

namespace _35_Dedicnost_Dopravni_prostredky
{
    class Program
    {
        static void Main(string[] args)
        {
            Flotila f = new Flotila();
            f.PridejVozidlo(new ElektroAuto(160, 2));
            f.PridejVozidlo(new DieselAuto(180, 5));
            

            Console.WriteLine(f.Kapacita);
            f.Natankuj();

            f.PridejVozidlo(new DieselAuto(130, 5));

            Console.WriteLine();
            f.OdvezRychle(2);

            Console.WriteLine();
            f.OdvezRychle(6);

            Console.WriteLine();
            f.OdvezRychle(8);

            Console.WriteLine();
            f.OdvezRychle(15);

            f.PridejVozidlo(new Motocykl(220));

            Console.WriteLine(String.Join(", ", f.Pohony));
        }
    }
}
