using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Dedicnost_Dopravni_prostredky
{

    //Vytvořte uzavřenou třídu Bicykl, která dědí z DP.
    sealed class Bicykl : DopravniProstredek
    {
        //Konstruktor bude přijímat pouze maximální rychlost.Bude volat konstruktor bázové třídy a předávat mu reálné parametry (název je "bicykl", pohon je "manuální")
        public Bicykl(double maxRychlost) : base("bicykl", TypPohonu.Manualni, maxRychlost, 1)
        {
        }

        //Natankuj() vypíše do konzole "jdu na svačinu" :)
        public override void Natankuj()
        {
            Console.WriteLine("jdu na svačinu");
        }
    }
}
