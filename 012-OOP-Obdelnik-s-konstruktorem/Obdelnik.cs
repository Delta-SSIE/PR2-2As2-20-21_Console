using System;
using System.Collections.Generic;
using System.Text;

namespace _012_OOP_Obdelnik_s_konstruktorem
{
    class Obdelnik
    {
        private double _stranaA;
        private double _stranaB;
        
        public Obdelnik()
        {
            _stranaA = 0; // nastavení double na 0 není nutné, dělá už .NET sám od sebe
            _stranaB = 0; // explicitní nastavení ale ničemu neškodí
        }
        public Obdelnik(double stranaA, double stranaB)
        {
            NastavA(stranaA);
            NastavB(stranaB);
        }
        public double VratA()
        {
            return _stranaA;
        }
        public void NastavA(double hodnota)
        {
            if (hodnota < 0)
                throw new System.ArgumentOutOfRangeException();
            else
                _stranaA = hodnota;
        }
        public double VratB()
        {
            return _stranaB;
        }
        public void NastavB(double hodnota)
        {
            if (hodnota < 0)
                throw new System.ArgumentOutOfRangeException();
            else
                _stranaB = hodnota;
        }
        public double Obvod()
        {
            return 2 * (_stranaA + _stranaB);
        }
        public double Obsah()
        {
            return _stranaA * _stranaB;
        }
    }
}
