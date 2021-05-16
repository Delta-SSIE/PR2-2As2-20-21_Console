using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_automobil
{
    class Automobil
    {
        private string _barva;
        public string Barva
        {
            get { return this._barva; }
            set
            {
                if ((value == "černá") || (value == "bílá") || (value == "červená") || (value == "stříbrná"))
                    this._barva = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        private double _velikostNadrze;
        public double VelikostNadrze
        {
            get { return this._velikostNadrze; }
        }

        private double _stavPaliva;
        public double StavPaliva
        {
            get { return this._stavPaliva; }
        }

        private int _zarazeno = 0;
        public int Zarazeno
        {
            get { return this._zarazeno; }
        }

        private double[] _spotrebaData = new double[] { 8.5, Double.PositiveInfinity, 9.6, 7.7, 6.8, 6.2, 6.5 };
        private double spotreba
        {
            get { return _spotrebaData[this._zarazeno + 1]; }
        }

        public Automobil(string barva, double velikostNadrze)
        {
            this.Barva = barva;
            if (velikostNadrze > 0)
                this._velikostNadrze = velikostNadrze;
            else
                throw new ArgumentOutOfRangeException();
            this._stavPaliva = 5;
        }

        public bool JeStupenPripustny(int rychlostniStupen)
        {
            return rychlostniStupen >= -1 && rychlostniStupen <= 5;
        }

        public void Zarad()
        {
            if (JeStupenPripustny(_zarazeno + 1))
                this._zarazeno++;
            else
                Console.WriteLine("Nelze řadit výš");
        }
        public void Podrad()
        {
            if (JeStupenPripustny(_zarazeno - 1))
                this._zarazeno--;
            else
                Console.WriteLine("Nelze řadit níž");
        }
        public void Neutral()
        {
            this._zarazeno = 0;
        }

        public void Natankuj(double kolik)
        {
            if (this._stavPaliva + kolik < this._velikostNadrze)
                this._stavPaliva += kolik;
            else
            {
                this._stavPaliva = this._velikostNadrze;
                Console.WriteLine("Tolik se do nádrže nevejde, dáme tam plnou");
            }
        }

        public void Ujed(double vzdalenost)
        {
            double spotrebovano = vzdalenost * this.spotreba / 100;
            if (spotrebovano <= this._stavPaliva)
            {
                this._stavPaliva -= spotrebovano;
            }
            else
            {
                Console.WriteLine("Nedostatek paliva!");
                this._stavPaliva = 0;
            }
        }

        public double Dojezd()
        {
            return this._stavPaliva / this.spotreba * 100;
        }

        public bool DojedeDalNez(Automobil jineAuto)
        {
            return this.Dojezd() > jineAuto.Dojezd();
        }

        public override string ToString()
        {
            return String.Format("Automobil, barva {0}, stav paliva {1}/{2} litrů", this._barva, this._stavPaliva, this._velikostNadrze);
        }

    }
}
