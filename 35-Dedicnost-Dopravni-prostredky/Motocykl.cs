using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Dedicnost_Dopravni_prostredky
{
    //Vytvořte uzavřenou třídu Motocykl, která dědí z DP.

    sealed class Motocykl : DopravniProstredek
    {
        //Konstruktor bude přijímat pouze maximální rychlost.Bude volat konstruktor bázové třídy a předávat mu reálné parametry (pohon je "spalovací", počet míst 2)
        public Motocykl(double maxRychlost) : base("motocykl", TypPohonu.SpalovaciMotor, maxRychlost, 2) {}

        //Natankuj() vypíše do konzole "Plním nádrž benzínem"
        public override void Natankuj()
        {
            Console.WriteLine("Plním nádrž benzínem.");
        }
    }
}
