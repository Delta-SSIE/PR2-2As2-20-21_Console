using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Iface_demo
{
    enum VyskaKarty : byte { Sedma, Osma, Devitka, Desitka, Svrsek, Spodek, Kral, Eso };
    enum BarvaKarty : byte { Kule, Zaludy, Listy, Srdce };
    //enum Porovnani : byte { PrvniMensi, ObeStejne, DruhaMensi };

    class Karta : IComparable
    {
        public VyskaKarty Vyska { get; private set; }
        public BarvaKarty Barva { get; private set; }

        public Karta(VyskaKarty vyska, BarvaKarty barva)
        {
            Vyska = vyska;
            Barva = barva;
        }

        //public Porovnani SrovnejS(Karta druhaKarta)
        //{
        //    if (Vyska < druhaKarta.Vyska)
        //        return Porovnani.PrvniMensi;
        //    else if (Vyska == druhaKarta.Vyska)
        //        return Porovnani.ObeStejne;
        //    else
        //        return Porovnani.DruhaMensi;
        //}

        public override string ToString()
        {
            return $"Karta ({Barva}, {Vyska})";
        }

        public int CompareTo(object obj)
        {
            Karta druhaKarta = (Karta)obj;
            if (Vyska < druhaKarta.Vyska)
                return -1;
            else if (Vyska == druhaKarta.Vyska)
                return 0;
            else
                return 1;
        }

        public static bool operator> (Karta kartaA, Karta kartaB)
        {
            return kartaA.Vyska > kartaB.Vyska;
        }
        public static bool operator< (Karta kartaA, Karta kartaB)
        {
            return kartaA.Vyska < kartaB.Vyska;
        }
        public static bool operator>= (Karta kartaA, Karta kartaB)
        {
            return kartaA.Vyska >= kartaB.Vyska;
        }
        public static bool operator<= (Karta kartaA, Karta kartaB)
        {
            return kartaA.Vyska <= kartaB.Vyska;
        }
    }
}
