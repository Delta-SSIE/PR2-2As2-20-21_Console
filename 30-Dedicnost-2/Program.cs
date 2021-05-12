using System;

namespace _30_Dedicnost_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Savec savec = new Savec();
            //savec.Dychej();

            Kun ferda = new Kun("Ferda", "Fanouš", "Žanka");
            Kun linda = new Kun("Linda", "Zoro", "Titty");
            Kun dan = new Kun("Daniel", ferda, linda);


            //ferda.Cvalej();
            //ferda.Dychej();
            //Console.WriteLine(ferda.Jmeno);
            //Console.WriteLine($"{ferda.Jmeno} ({ferda.Otec}, {ferda.Matka})");


            //Console.WriteLine();
            //Console.WriteLine($"{dan.Jmeno} ({dan.Otec}, {dan.Matka})");


            //Velryba mobyDick = new Velryba();
            //mobyDick.Dychej();
            //mobyDick.Plav();
            ////mobyDick.Cvalej(); // nelze - není deklarováno


            //Savec s1 = new Kun();
            ////Savec s1 = new Velryba();
            ////s1.Cvalej(); //nelze, není na savci deklarováno, i když je to vlastné kůň "uvnitř"
            //Kun konik = (Kun)s1; //type casting, type juggling, lze protože s1 opravdu je kůň
            //konik.Cvalej(); //teď lze cválat, protože propměnná konik má deklarován typ Kun, ktery obsahuje metodu Cvalej


            //Savec savec = new Savec("Bobík"); //nelze - savec je abstraktní
            //savec.Dychej();

            Velryba mobyDick = new Velryba("Moby Dick");
            //mobyDick.Dychej();
            //mobyDick.Plav();

            //Savec savec = mobyDick;
            //savec.OzviSe();
            //savec = dan;
            //savec.OzviSe();

            //mobyDick.Cvalej(); // nelze - není deklarováno


            //ukázka polymorfizmu
            Savec[] savci = new Savec[3];
            savci[0] = new Kun("Ferda", "John", "Linda");
            savci[1] = new Velryba("Billie");
            savci[2] = new Pes("Punťa");

            foreach (Savec potvora in savci)
            {
                potvora.OzviSe();
                //Console.WriteLine(potvora.Vek);
            }
        }
    }
}
