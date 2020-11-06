using System;
using System.Collections.Generic;
using System.Text;

namespace _017_OOP_Ucet_2
{
    class Ucet
    {
        public double Zustatek { get; private set; }
        private string _heslo;
        public string Log { get; private set; }

        public Ucet(string heslo)
        {
            _heslo = heslo;
            Log = "";
            Zustatek = 0;
            Zaloguj("Účet založen");
        }
        public void Uloz(double castka)
        {
            Zustatek += castka;
            Zaloguj($"Vklad {castka}");
        }
        public bool Vyber(double castka, string heslo)
        {
            if (heslo != _heslo)
            {
                Zaloguj("Chybné heslo při výběru");
                return false; //špatné heslo
            }
            //když na to mám
            if (castka <= Zustatek)
            {
                Zaloguj($"Výběr {castka}");
                Zustatek -= castka;
                return true;
            }
            else
            {
                Zaloguj("Výběr - nedostatek financí");
                return false;
            }
        }
        public void Urokuj(double urokovaSazba)
        {
            double koeficient = 1 + urokovaSazba / 100;
            Zustatek *= koeficient;
            Zaloguj("Úrokování");
        }
        public bool ZmenHeslo(string stareHeslo, string noveHeslo)
        {
            //když je staré heslo správně
            if (stareHeslo == _heslo)
            {
                Zaloguj("Změna hesla");
                _heslo = noveHeslo;
                return true;
            }
            else
            {
                Zaloguj("Chyba změny hesla");
                return false;
            }
        }
        private void Zaloguj(string text)
        {
            Log += text;
            Log += System.Environment.NewLine;
        }
    }
}
