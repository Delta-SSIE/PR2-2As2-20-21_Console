using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Dedicnost_2
{
    class Velryba : Savec
    {

        public Velryba(string jmeno) : base(jmeno) { }

        public void Plav()
        {
            Console.WriteLine("Nechávám za sebou na hladině čáru.");
        }
    }
}
