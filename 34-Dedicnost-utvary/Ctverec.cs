using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Dedicnost_utvary
{
    sealed class Ctverec : Utvar
    {
        //veřejnou vlastnost Strana(double) se soukromým zápisem
        public double Strana { get; private set; }

        //konstruktor, kterému se bude předávat strana a on ji uloží.Konstruktor bude volat konstruktor bázové třídy s parametrem "ctverec"
        public Ctverec(double strana) : base("čtverec")
        {
            Strana = strana;
        }

        //deklarovánu metodu ToString(), která přepíše původní ToString() a vrací text "Čtverec o straně ..."
        public override string ToString()
        {
            return $"Čtverec o straně {Strana} cm";
        }

        //implementovány metody Obvod() a Obsah()
        public override double Obvod()
        {
            return 4 * Strana;
        }

        public override double Obsah()
        {
            return Strana * Strana;
        }

    }
}
