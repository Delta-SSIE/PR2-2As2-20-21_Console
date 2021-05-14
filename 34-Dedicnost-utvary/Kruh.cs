using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Dedicnost_utvary
{
    sealed class Kruh : Utvar
    {
        //veřejnou vlastnost Strana(double) se soukromým zápisem
        public double Polomer { get; private set; }

        //konstruktor, kterému se bude předávat poloměr a on jej uloží. Konstruktor bude volat konstruktor bázové třídy s parametrem "kruh"
        public Kruh(double strana) : base("kruh")
        {
            Polomer = strana;
        }

        //deklarovánu metodu ToString(), která přepíše původní ToString() a vrací text "Kruh o poloměru ..."
        public override string ToString()
        {
            return $"Kruh o poloměru {Polomer} cm";
        }

        //implementovány metody Obvod() a Obsah()
        public override double Obvod()
        {
            return 2 * Math.PI * Polomer;
        }

        public override double Obsah()
        {
            return Math.PI * Polomer * Polomer;
        }
    }
}
