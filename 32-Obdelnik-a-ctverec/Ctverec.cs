using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Obdelnik_a_ctverec
{
    class Ctverec : Obdelnik
    {
        public double Strana 
        { 
            get 
            { 
                return StranaA; 
            } 
        }

        public Ctverec(double strana) : base(strana, strana) {}
    }
}
