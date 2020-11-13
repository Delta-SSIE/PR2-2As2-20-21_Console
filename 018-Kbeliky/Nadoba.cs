using System;
using System.Collections.Generic;
using System.Text;

namespace _018_Kbeliky
{
    class Nadoba
    {
        private double _objem;
        private double _objemVody = 0;

        public Nadoba(double objemNadoby)
        {
            if (objemNadoby <= 0) throw new ArgumentOutOfRangeException();
            this._objem = objemNadoby;
        }
        public double ObjemVody
        {
            get { 
                return this._objemVody; 
            }
        }
        public double VolnyObjem
        {
            get { 
                return this._objem - this._objemVody; 
            }
        }
        public void Napln()
        {
            this._objemVody = this._objem;
        }
        public void Vylij()
        {
            this._objemVody = 0;
        }
        public void PrelejDo(Nadoba kam)
        {
            if (this._objemVody <= kam.VolnyObjem)
            {
                kam._objemVody += this._objemVody;
                this._objemVody = 0;
            }
            else
            {
                this._objemVody -= kam.VolnyObjem;
                kam._objemVody = kam._objem;
            }
        }
        public void PrelejDo2(Nadoba kam)
        {
            double kolik = Math.Min(this._objem, kam.VolnyObjem);
            this._objemVody -= kolik;
            kam._objemVody += kolik;
        }
        public void Prilej(Nadoba odkud)
        {
            odkud.PrelejDo(this);
        }
        public override string ToString()
        {
            return string.Format("Nádoba {0} l / {1} l", this._objemVody, this._objem);
        }

    }
}
