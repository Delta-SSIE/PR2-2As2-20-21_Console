using System;
using System.Collections.Generic;
using System.Text;

namespace _017_OOP_Ucet_2
{
    class Ucet
    {
        public double Zustatek { get; private set; }
        private string _heslo;

        public Ucet(string heslo)
        {
            _heslo = heslo;
            Zustatek = 0;
        }
        public void Uloz(double castka)
        {
            Zustatek += castka; 
        }
        public bool Vyber(double castka, string heslo)
        {
            if (heslo != _heslo)
            {
                return false; //špatné heslo
            }
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
        public bool ZmenHeslo(string stareHeslo, string noveHeslo)
        {
            //když je staré heslo správně
            if (stareHeslo == _heslo)
            {
                _heslo = noveHeslo;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
