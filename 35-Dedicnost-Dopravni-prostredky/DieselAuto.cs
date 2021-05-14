using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Dedicnost_Dopravni_prostredky
{
    //Vytvořte uzavřenou třídu DieselAuto, která dědí z Automobil
    sealed class DieselAuto : Automobil
    {
        //Konstruktor bude přijímat jen MaxRychlost a PocetMist, pak zavolá konstruktor bázové třídy a vše jí předá(pohon je "spalovací")

        public DieselAuto(double maxRychlost, int pocetMist) : base(TypPohonu.SpalovaciMotor, maxRychlost, pocetMist) { }

        //Natankuj() vypíše do konzole "Plním nádrž naftou"
        public override void Natankuj()
        {
            Console.WriteLine("Plním nádrž naftou");
        }    
    }
}
