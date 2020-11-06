using System;
using System.Collections.Generic;
using System.Text;

namespace _016_OOP_Ucet
{
    class Ucet
    {
        public double Zustatek { get; private set; }
        public string Vlastnik { get; private set; }

        public Ucet(string vlastnik)
        {
            Vlastnik = vlastnik;
            Zustatek = 0;
        }
        public void Uloz(double castka)
        {
            Zustatek += castka; 
        }
        public bool Vyber(double castka)
        {
            //když na to mám
            if (castka <= Zustatek)
            {
                Zustatek -= castka;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Urokuj(double urokovaSazba)
        {
            double koeficient = 1 + urokovaSazba / 100;
            Zustatek *= koeficient;
        }
    }
}
