using System;
using System.Collections.Generic;
using System.Text;

namespace _25_Bludiste_LinkList
{
    class Krizovatka
    {
        public char Popis { get; private set; }
        public List<Krizovatka> Odbocky { get; private set; }
        public List<Krizovatka> Cesta { get; set; }

        public int Krok { get; set; }

        public Krizovatka(char popis)
        {
            Popis = popis;
            Krok = -1; //to znamená, že jsem zde ještě nebyl
            Odbocky = new List<Krizovatka>();
            Cesta = new List<Krizovatka>();
        }

        public void PridejCestu(Krizovatka kam)
        {
            Odbocky.Add(kam);
        }

    }
}
