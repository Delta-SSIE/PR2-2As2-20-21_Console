using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Dedicnost_2
{
    sealed class Pes : Savec
    {
        public Pes(string jmeno) : base(jmeno)
        {
        }

        public override void OzviSe()
        {
            Console.WriteLine("Haf!");
        }
    }
}
