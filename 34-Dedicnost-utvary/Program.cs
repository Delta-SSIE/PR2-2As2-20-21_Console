using System;
using System.Linq;

namespace _34_Dedicnost_utvary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vytvořte pole objektů třídy Utvar
            //Utvar[] obrazce = new Utvar[3];

            ////uložte do něj nejméně jeden útvar každého typu
            //obrazce[0] = new Ctverec(5);
            //obrazce[1] = new Trojuhelnik(3, 4, 5);
            //obrazce[2] = new Kruh(4);

            Utvar[] obrazce = new Utvar[] {
                new Ctverec(5),
                new Trojuhelnik(3, 4, 5),
                new Kruh(4)
            };

            //projděte pole cyklem a vypište "podpisy"(ToString) všech obrazců v něm
            foreach (Utvar obrazec in obrazce)
            {
                Console.WriteLine(obrazec);
            }

            //zjistěte celkový obvod a obsah všech útvarů v poli
            //double totalObsah = 0;
            //double totalObvod = 0;
            //foreach (Utvar obrazec in obrazce)
            //{
            //    totalObsah += obrazec.Obsah();
            //    totalObvod += obrazec.Obvod();
            //}

            double totalObvod = obrazce.Select(x => x.Obvod()).Sum();
            double totalObsah = obrazce.Select(x => x.Obsah()).Sum();

            Console.WriteLine($"Celkový obvod je {totalObvod} cm, celkový obsah je {totalObsah} cm2.");


            PixlaBarvy pixla = new PixlaBarvy(5, 2);
            foreach (Utvar utvar in obrazce)
            {
                if (pixla.Obarvi(utvar))
                {
                    Console.WriteLine($"Obarvil jsem {utvar}, stav pixly: {pixla}");
                }
                else
                {
                    Console.WriteLine($"Nelze obarvit {utvar}, stav pixly: {pixla}");
                }
            }
        }
    }
}
