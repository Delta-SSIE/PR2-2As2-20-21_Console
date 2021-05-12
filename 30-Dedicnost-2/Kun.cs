using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Dedicnost_2
{

    class Kun : Savec
    {
        public string Otec { get; private set; }
        public string Matka { get; private set; }

        public Kun(string jmeno, string otec, string matka) : base(jmeno) 
        {
            Otec = otec;
            Matka = matka;
        }

        public Kun(string jmeno, Kun otec, Kun matka) : base(jmeno)
        {
            Otec = otec.Jmeno;
            Matka = matka.Jmeno;
        }

        public void Cvalej()
        {
            Console.WriteLine("Klapity klap");
        }

        public override void OzviSe()
        {
            Console.WriteLine("Íhahá");
            Vek++;
        }

    }

}
