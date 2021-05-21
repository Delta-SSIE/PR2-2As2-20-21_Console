using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Dedicnost_Dopravni_prostredky
{
    //Vytvořte uzavřenou třídu ElektroAuto, která dědí z Automobil
    sealed class ElektroAuto : Automobil
    {
        //Konstruktor bude přijímat jen MaxRychlost a PocetMist, pak zavolá konstruktor bázové třídy a vše jí předá(pohon je "elektromotor")
        public ElektroAuto(double maxRychlost, int pocetMist) : base(TypPohonu.Elektromotor, maxRychlost, pocetMist)
        {
        }

        //Natankuj() vypíše do konzole "Připojuji na nabíječku
        public override void Natankuj()
        {
            Console.WriteLine("Připojuji na nabíječku");
        }
    }
}
