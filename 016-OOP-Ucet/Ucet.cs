using System;
using System.Collections.Generic;
using System.Text;

namespace _016_OOP_Ucet
{
    class Ucet
    {
        private double _zustatek;
        private string _vlastnik;

        public double Zustatek
        {
            get
            {
                return _zustatek;
            }

        }
        public Ucet(string vlastnik)
        {
            _vlastnik = vlastnik;
            _zustatek = 0;
        }
        public void Uloz(double castka)
        {
            _zustatek += castka; 
        }
        public bool Vyber(double castka)
        {
            //když na to mám
            if (castka <= _zustatek)
            {
                _zustatek -= castka;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
