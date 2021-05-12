using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Dedicnost_2
{
    abstract class Savec
    {
        public string Jmeno { get; private set; }

        //public abstract int Vek { get; set; } //abstraktní mohou být i vlastnosti

        protected int Vek = 0; //protected přístupné v této a dědících třídách, nepřístupné z venku

        public Savec(string jmeno)
        {
            if (jmeno.Length < 1)
                throw new ArgumentException();

            Jmeno = jmeno;
        }

        public void Dychej()
        {
            Console.WriteLine("Nádech ... Výdech ...");
        }


        public void SajMleko()
        {
            Console.WriteLine("To je dobrota...");
        }

        public abstract void OzviSe(); //abstraktní metoda
    }
}
