using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Dedicnost_utvary
{
    sealed class Trojuhelnik : Utvar
    {
        //veřejné vlastnosti Strana1, Strana2 a Strana3(double) se soukromým zápisem
        public double Strana1 { get; private set; }
        public double Strana2 { get; private set; }
        public double Strana3 { get; private set; }

        public Trojuhelnik(double strana1, double strana2, double strana3) : base("trojúhelník")
        {
            Strana1 = strana1;
            Strana2 = strana2;
            Strana3 = strana3;
        }

        public override string ToString()
        {
            return $"Trojúhelník o stranách {Strana1} cm, {Strana2} cm a {Strana3} cm";
        }

        public override double Obvod()
        {
            return Strana1 + Strana2 + Strana3;
        }

        public override double Obsah()
        {
            double s = Obvod() / 2;
            return Math.Sqrt(s * (s - Strana1) * (s - Strana2) * (s - Strana3));
        }
    }
}
