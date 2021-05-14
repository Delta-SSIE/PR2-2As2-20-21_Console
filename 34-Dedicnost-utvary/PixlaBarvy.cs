using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Dedicnost_utvary
{
    //Vytvořte třídu PixlaBarvy


    class PixlaBarvy
    {
        /// <summary>
        /// Objem barvy v mililitrech
        /// </summary>
        public double Objem { get; private set; }
        /// <summary>
        /// Kolik cm2 obarví jeden ml|
        /// </summary>
        public double Vydatnost { get; private set; }

        //bude v konstruktoru dostávat desetinná čísla objem a vydatnost, která si uloží.Čísla znamenají, kolik mililitrů v "pixle" je a kolik cm2 obarví jeden ml
        public PixlaBarvy(double objem, double vydatnost)
        {
            Objem = objem;
            Vydatnost = vydatnost;
        }
        //bude mít veřejnou metodu ToString(), která bude vracet něco jako "Pixla barvy, zbývá jí ještě na 60 cm2".
        public override string ToString()
        {
            return $"Pixla barvy, zbývá jí ještě na {ZbyvaPlochy()} cm2";
        }
        private double ZbyvaPlochy()
        {
            return Objem * Vydatnost;
        }

        //bude mít veřejnou metodu Obarvi(), která obrdží Utvar a pokud je v pixle dost barvy na jeho obarvení, sníží svůj objem a vrátí true (úspěch), jinak si ponechá původní objem a vrátí false (neúspěch)
        public bool Obarvi(Utvar utvar)
        {
            if (ZbyvaPlochy() >= utvar.Obsah())
            {
                //bude se barvit
                double spotreba = utvar.Obsah() / Vydatnost;
                Objem -= spotreba;
                return true;
            }
            else
            {
                //není dost barvy
                return false;
            }
        }
    }
}
