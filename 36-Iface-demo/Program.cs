using System;
using System.Collections.Generic;

namespace _36_Iface_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Karta> karty = new List<Karta>();
            karty.Add(new Karta(VyskaKarty.Desitka, BarvaKarty.Kule));
            karty.Add(new Karta(VyskaKarty.Desitka, BarvaKarty.Srdce));
            karty.Add(new Karta(VyskaKarty.Eso, BarvaKarty.Listy));
            karty.Add(new Karta(VyskaKarty.Sedma, BarvaKarty.Srdce));
            karty.Add(new Karta(VyskaKarty.Devitka, BarvaKarty.Zaludy));

            karty.Sort();
            Console.WriteLine(String.Join(", ", karty));

            Karta kartaA = new Karta(VyskaKarty.Devitka, BarvaKarty.Zaludy);
            Karta kartaB = new Karta(VyskaKarty.Desitka, BarvaKarty.Zaludy);
            
            if (kartaA > kartaB)
            {
                Console.WriteLine("karta A je větší než karta B");
            }


        }
    }
}
