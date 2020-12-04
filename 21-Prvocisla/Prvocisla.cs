using System;
using System.Collections.Generic;
using System.Text;

namespace _21_Prvocisla
{
    class Prvocisla
    {
        public static bool JePrvocislo(int cislo) //testuje, jestli je prvočíslo
        {
            for (int zkousim = 2; zkousim < Math.Sqrt(cislo); zkousim++) //vyzkouší všechna čísla podezřelá, že by mohla být dělitelem
            {
                if (cislo % zkousim == 0) //zjistí zbytek po dělení
                {
                    return false; //našel jsem dělitele, vracím false (NENÍ prvočíslo)
                }
            }

            return true; //vše doběhlo, nenašel jsem dělitele => dělitel není, vracím true (JE prvočíslo)
        }

        public static int[] PrvocislaDo(int maximum)
        {
            //připrav si řadu čísel do maxima
            bool[] cisla = new bool[maximum + 1];
            List<int> prvocisla = new List<int>();

            cisla[0] = false; //tohle určitě nebudou prvočísla
            cisla[1] = false;

            for (int i = 2; i < cisla.Length; i++)
            {
                cisla[i] = true; //nastavím jako podezřelé
            }

            //projdi ji takto:
            for (int podezreleCislo = 2; podezreleCislo < cisla.Length; podezreleCislo++)
            {
                //škrtnutá čísla přeskoč
                if (!cisla[podezreleCislo])
                {
                    continue;
                }

                //první neškrtnuté označ jako prvočíslo, jeho násobky škrtni
                prvocisla.Add(podezreleCislo);

                for (int nasobek = 2 * podezreleCislo; nasobek < cisla.Length; nasobek += podezreleCislo)
                {
                    cisla[nasobek] = false;
                }
            }

            return prvocisla.ToArray();
        }
    }
}
