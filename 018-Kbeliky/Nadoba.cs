using System;
using System.Collections.Generic;
using System.Text;

namespace _018_Kbeliky
{
    class Nadoba
    {
        private double objem;
        private double objemVody = 0;

        public Nadoba(double objemNadoby)
        {
            if (objemNadoby <= 0) throw new ArgumentOutOfRangeException();
            this.objem = objemNadoby;
        }
        public double ObjemVody
        {
            get { return this.objemVody; }
        }
        public double VolnyObjem
        {
            get { return this.objem - this.objemVody; }
        }
        public void Napln()
        {
            this.objemVody = this.objem;
        }
        public void Vylij()
        {
            this.objemVody = 0;
        }
        public void PrelejDo(Nadoba kam)
        {
            if (this.objemVody <= kam.VolnyObjem)
            {
                kam.objemVody += this.objemVody;
                this.objemVody = 0;
            }
            else
            {
                this.objemVody -= kam.VolnyObjem;
                kam.objemVody = kam.objem;
            }
        }
        public void PrelejDo2(Nadoba kam)
        {
            double kolik = Math.Min(this.objem, kam.VolnyObjem);
            this.objemVody -= kolik;
            kam.objemVody += kolik;
        }
        public void Prilej(Nadoba odkud)
        {
            odkud.PrelejDo(this);
        }
        public override string ToString()
        {
            return string.Format("Nádoba {0} l / {1} l", this.objemVody, this.objem);
        }

    }
}
