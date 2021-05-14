using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Dedicnost_utvary
{
    abstract class Utvar
    {
        //konstruktor, kterému se bude předávat název a on jej uloží
        public Utvar(string nazev)
        {
            Nazev = nazev;
        }

        //veřejnou vlastnost Nazev(string) se soukromým zápisem
        public string Nazev { get; private set; }

        //veřejné abstraktní metody, které Obvod() a Obsah() (vrací double)
        public abstract double Obvod();
        public abstract double Obsah();
    }
}
