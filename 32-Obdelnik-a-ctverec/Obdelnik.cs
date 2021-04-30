using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Obdelnik_a_ctverec
{
    class Obdelnik
    {
        public double StranaA { get; private set; }
        public double StranaB { get; private set; }

        public double Obvod()
        {
            return (StranaA + StranaB) * 2;
        }

        public double Obsah()
        {
            return StranaA * StranaB;
        }

        public override string ToString()
        {
            return $"Obdélník o stranách {StranaA} a {StranaB}";
        }

        public Obdelnik(double stranaA, double stranaB)
        {
            if (stranaA <= 0 || stranaB <= 0)
                throw new ArgumentOutOfRangeException();

            StranaA = stranaA;
            StranaB = stranaB;
        }


    }
}
