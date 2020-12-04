using System;
using System.Collections.Generic;
using System.Text;

namespace _22_Prebijena
{
    enum VyskaKarty : byte { Sedma, Osma, Devitka, Desitka, Svrsek, Spodek, Kral, Eso };
    enum BarvaKarty : byte { Kule, Zaludy, Listy, Srdce };
    enum Porovnani : byte { PrvniMensi, ObeStejne, DruhaMensi }; 

    class Karta
    {
        public VyskaKarty Vyska { get; private set; }
        public BarvaKarty Barva { get; private set; }

        public Karta(VyskaKarty vyska, BarvaKarty barva)
        {
            Vyska = vyska;
            Barva = barva;
        }

        public Porovnani SrovnejS(Karta druhaKarta)
        {
            if (Vyska < druhaKarta.Vyska)
                return Porovnani.PrvniMensi;
            else if (Vyska == druhaKarta.Vyska)
                return Porovnani.ObeStejne;
            else
                return Porovnani.DruhaMensi;
        }

        public override string ToString()
        {
            return $"Karta ({Barva}, {Vyska})";
        }
    }
}
