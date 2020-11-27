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
    }
}
