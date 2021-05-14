using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Dedicnost_Dopravni_prostredky
{
    abstract class DopravniProstredek
    {
        //Veřejné vlastnosti Nazev(string), Pohon(TypPohonu), MaxRychlost(double) a PocetMist(int)
        public string Nazev { get; private set; }
        public TypPohonu Pohon { get; private set; }
        public double MaxRychlost  { get; private set; }
        public int PocetMist  { get; private set; }

        //Konstruktor, který obdrží a uloží předchozí parametry
        public DopravniProstredek(string nazev, TypPohonu pohon, double maxRychlost, int pocetMist)
        {
            Nazev = nazev;
            Pohon = pohon;
            MaxRychlost = maxRychlost;
            PocetMist = pocetMist;
        }

        //Abstraktní metodu Natankuj(), která nic nevrací
        public abstract void Natankuj();

        //nějaký pěkný ToString() sestavený z vlastností prostředku
        public override string ToString()
        {
            return $"{Nazev}, max. rychlost: {MaxRychlost} km/h, počet míst: {PocetMist}";
        }
    }
}
