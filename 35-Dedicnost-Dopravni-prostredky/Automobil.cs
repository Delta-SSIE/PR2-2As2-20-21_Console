using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Dedicnost_Dopravni_prostredky
{
    //Vytvořte abstraktní třídu Automobil, která dědí z DP.
    abstract class Automobil : DopravniProstredek
    {
        //Konstruktor bude přijímat všechny parametry z bodu 1 kromě názvu, pak zavolá konstruktor bázové třídy a vše jí předá(název je "automobil")
        protected Automobil(TypPohonu pohon, double maxRychlost, int pocetMist) : base("automobil", pohon, maxRychlost, pocetMist) {}
    }
}
