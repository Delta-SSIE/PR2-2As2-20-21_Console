using System;

namespace _30_Dedicnost_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Savec savec = new Savec();
            //savec.Dychej();

            //Kun ferda = new Kun();
            //ferda.Cvalej();
            //ferda.Dychej();

            //Velryba mobyDick = new Velryba();
            //mobyDick.Dychej();
            //mobyDick.Plav();
            ////mobyDick.Cvalej(); // nelze - není deklarováno


            Savec s1 = new Kun();
            //Savec s1 = new Velryba();
            // s1.Cvalej(); - nelze, není na savci deklarováno, i když je to vlastné kůň "uvnitř"
            Kun konik = (Kun) s1; //type casting, type juggling
            konik.Cvalej();


        }
    }
}
