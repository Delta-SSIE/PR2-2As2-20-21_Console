using System;
using System.Collections.Generic;
using System.Text;

namespace _019_Geometrie
{
    class Obdelnik
    {

        private double _stranaA;
        public double StranaA
        {
            get
            {
                return _stranaA;
            }
            private set
            {
                if (value >= 0)
                    _stranaA = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        private double _stranaB;
        public double StranaB
        {
            get
            {
                return _stranaB;
            }
            set
            {
                if (value >= 0)
                    _stranaB = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        public Obdelnik()
        { }//bez tohoto prázdného konstruktoru by nebylo možné vytvořit obdélník s ještě nedefinovanými stranami
        public Obdelnik(double stranaA, double stranaB)
        {
            StranaA = _stranaA; //používáme vlastnost i zevnitř konstruktoru - zajistí kontrolu přípustnosti hodnoty
            StranaB = _stranaB;
        }
        public double Obsah()
        {
            return _stranaA * _stranaB;
        }
        public double Obvod()
        {
            return 2 * (_stranaA + _stranaB);
        }
        public Bod PravyDolni(Bod levyHorni)
        {
            //sem vepište metodu, která dostane předán levý horní bod a vrátí pravý dolní bod

            throw new NotImplementedException();
            //tímto říkám, že když sem program dojde, má civilizovaně
            //spadnout a říci "ještě není implementováno"
            //
            //až metodu implementujete, odstraňte
        }
    }
}
