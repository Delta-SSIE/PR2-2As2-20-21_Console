using System;
using System.Linq;
using System.Collections.Generic;

namespace _21_Prvocisla
{
    class Program
    {
        static void Main(string[] args)
        {

            int max = 5000;
            List<int> prvocisla = new List<int>(); //seznam pro prvočísla

            for (int cislo = 2; cislo <= max; cislo++) // zační na 2, skončí na max
            {
                if (Prvocisla.JePrvocislo(cislo)) //když je prvočíslo
                    prvocisla.Add(cislo); //zapiš si ho do seznamu
            }

            //Console.WriteLine(string.Join(", ", prvocisla));

            // a nebo úplně jinak - vyžaduje System.Linq, zde byla chyba při hodině
            int[] prvocisla2 = Enumerable.Range(2, max - 1)
                .Where(x => Prvocisla.JePrvocislo(x))
                .ToArray();

            //Console.WriteLine(string.Join(", ", prvocisla2));

            Console.WriteLine(string.Join(", ", Prvocisla.PrvocislaDo(500) ));
        }
    }
}
