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
            StranaA = stranaA; //používáme vlastnost i zevnitř konstruktoru - zajistí kontrolu přípustnosti hodnoty
            StranaB = stranaB;
        }
        public Obdelnik(Bod roh1, Bod roh3)
        {
            double dx = roh1.x - roh3.x;
            double dy = roh1.y - roh3.y;

            StranaA = Math.Abs(dx);
            StranaB = Math.Abs(dy);
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
            Bod vysledek = new Bod(levyHorni.x + StranaA, levyHorni.y - StranaB);
            return vysledek;
        }
        public bool ObsahujeBod(Bod levyHorni, Bod dotazovany)
        {
            double dx = dotazovany.x - levyHorni.x;
            double dy = levyHorni.y - dotazovany.y;
            return dx >= 0
                    && dx <= StranaA
                    && dy >= 0
                    && dy <= StranaB;
        }
        public override string ToString()
        {
            return $"Obdélník [{_stranaA}, {_stranaB}]";
        }
    }
}
