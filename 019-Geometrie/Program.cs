using System;

namespace _019_Geometrie
{
    class Program
    {
        static void Main(string[] args)
        {
            Bod bodA = new Bod(0, 0);
            Bod bodB = new Bod(3, 6);
            Bod bodC = new Bod(1, -2);
            Bod klonA = bodA;

            //if (bodA.JeShodnyS(bodC))
            //{
            //    Console.WriteLine("Body A a C jsou shodné");
            //}
            //else
            //{
            //    Console.WriteLine("Body A a C shodné nejsou");
            //}

            //Console.WriteLine(bodA);


            //Console.WriteLine($"Vzdálenost bodů {bodA} a {bodB} je {bodA.VzdalenostOd(bodB)}.");

            Obdelnik obdABCD = new Obdelnik(4, 2);

            //Console.WriteLine(obdABCD.PravyDolni(new Bod(-1,3) ) );


            //Console.WriteLine(new Obdelnik(bodB, bodC));

            if (obdABCD.ObsahujeBod(bodA, bodC) )
            {
                Console.WriteLine($"Bod {bodC} leží uvnitř obdélníka {obdABCD} umístěného v bodě {bodA}");
            }
            else
            {
                Console.WriteLine($"Bod {bodC} neleží uvnitř obdélníka {obdABCD} umístěného v bodě {bodA}");
            }


        }
    }
}
