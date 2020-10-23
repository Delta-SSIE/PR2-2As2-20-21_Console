using System;
using System.Collections.Generic;
using System.Text;

namespace _014_OOP_Obdelnik_s_vlastnostmi
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

            set
            {
                if (value < 0)
                    throw new System.ArgumentOutOfRangeException();
                else
                    _stranaA = value;
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
                if (value < 0)
                    throw new System.ArgumentOutOfRangeException();
                else
                    _stranaB = value;
            }
        }


        
        public Obdelnik()
        {
            _stranaA = 0; // nastavení double na 0 není nutné, dělá už .NET sám od sebe
            _stranaB = 0; // explicitní nastavení ale ničemu neškodí
        }
        public Obdelnik(double stranaA, double stranaB)
        {
            StranaA = stranaA;
            StranaB = stranaB;
        }
        public double Obvod()
        {
            return 2 * (_stranaA + _stranaB);
        }
        //public double Obsah()
        //{
        //    return _stranaA * _stranaB;
        //}
        public double Obsah
        {
            get
            {
                return _stranaA * _stranaB;
            }
        }
    }
}
