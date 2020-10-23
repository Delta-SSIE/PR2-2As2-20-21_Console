using System;
using System.Collections.Generic;
using System.Text;

namespace _015_Kruznice_s_vlastnostmi
{
    class Kruznice
    {
        private double _polomer; //položka
        public double Polomer
        {
            get
            {
                return _polomer;
            }

            set
            {
                if (value >= 0)
                {
                    _polomer = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Negative radius is not allowed.");
                }
            }
        }

        public Kruznice()
        {
            Polomer = 0;
        }
        public Kruznice(double polomer)
        {
            Polomer = polomer;
        }

        public double Obsah 
        { 
            get
            { 
                return Math.PI * _polomer * _polomer;
            }
        }
        public double Obvod
        {
            get
            { 
                return 2 * Math.PI * _polomer;
            }
        }
    }
}
