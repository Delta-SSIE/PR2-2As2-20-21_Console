using System;
using System.Collections.Generic;
using System.Text;

namespace _013_Trojuhelnik
{
    class Trojuhelnik
    {
        private double _stranaA;
        private double _stranaB;
        private double _stranaC;
        public Trojuhelnik(double stranaA, double stranaB, double stranaC)
        {
            if (!lzeSestavit(stranaA, stranaB, stranaC))
            {
                throw new System.ArgumentException("Neplatná kombinace délek");
            }
            NastavA(stranaA);
            NastavB(stranaB);
            NastavC(stranaC);
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
        public double VratC()
        {
            return _stranaC;
        }
        public void NastavC(double hodnota)
        {
            if (hodnota < 0)
                throw new System.ArgumentOutOfRangeException();
            else
                _stranaC = hodnota;
        }
        public double Obvod()
        {
            return _stranaA + _stranaB + _stranaC;
        }
        public double Obsah()
        {
            double s = (_stranaA + _stranaB + _stranaC) / 2;
            return Math.Sqrt(s * (s - _stranaA) * (s - _stranaB) * (s - _stranaC));
        }
        private bool lzeSestavit(double a, double b, double c)
        {
            // vrátí true/false podle trojúhelníkové nerovnosti
            return a + b > c && a + c > b && b + c > a;

        }


    }
}
