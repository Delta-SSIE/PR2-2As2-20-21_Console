using System;
using System.Collections.Generic;
using System.Text;

namespace _010_OOP_uvod_demo1
{
    class Kruznice
    {
        private double _polomer; //položka
        public Kruznice()
        {
            NastavPolomer(0);
        }
        public Kruznice(double polomer)
        {
            NastavPolomer(polomer);
        }
        //Nelze - stejná sada argumentů jako předchozí - 1 double
        //public Kruznice(double prumer)
        //{
        //    NastavPolomer(prumer / 2);
        //}
        public void NastavPolomer(double polomer) //setter
        {
            if (polomer >= 0)
            {
                _polomer = polomer;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Negative radius is not allowed.");
            }
        }
        public double VratPolomer() //getter
        {
            return _polomer;
        }
        public double Plocha() //metoda
        { 
            return Math.PI * _polomer * _polomer; 
        }
        public double Obvod() //metoda
        {
            return 2 * Math.PI * _polomer;
        }
    }
}
