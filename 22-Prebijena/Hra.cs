using System;
using System.Collections.Generic;
using System.Text;

namespace _22_Prebijena
{
    class Hra
    {
        Balicek _hracA;
        Balicek _hracB;

        Random rnd = new Random();

        public bool JeKonec
        {
            get
            {
                return _hracA.PocetKaret == 0 || _hracB.PocetKaret == 0;
            }
        }
        public void Rozdej()
        {
            Balicek vsechnyKarty = new Balicek();
            vsechnyKarty.Napln();
            vsechnyKarty.Zamichej();

            _hracA = new Balicek();
            _hracB = new Balicek();

            //_hracA = new Balicek();
            //for (int i = 0; i < 16; i++)
            //{ 
            //    _hracA.DejDospod(vsechnyKarty.VezmiKartu());
            //}

            //_hracB = new Balicek();
            //for (int i = 0; i < 16; i++)
            //{
            //    _hracB.DejDospod(vsechnyKarty.VezmiKartu());
            //}

            Balicek komu = _hracA;
            while (vsechnyKarty.PocetKaret > 0)
            {
                komu.DejDospod(vsechnyKarty.VezmiKartu());
                komu = komu == _hracA ? _hracB : _hracA;
            }
        }
        public void Kolo()
        {
            //oba vezmou karty
            //porovnaji je
            //kdyz ma jeden vyssi, bere obe
            //pri shodnosti se opakuje

            List<Karta> vylozeno = new List<Karta>();
            Porovnani vysledek = Porovnani.ObeStejne;

            while (vysledek == Porovnani.ObeStejne && !JeKonec) { 

                Karta kartaA = _hracA.VezmiKartu();
                Console.WriteLine($"Hráč A nese {kartaA}");

                Karta kartaB = _hracB.VezmiKartu();
                Console.WriteLine($"Hráč B nese {kartaB}");

                if (rnd.Next(0, 2) == 0) { 
                    vylozeno.Add(kartaA);
                    vylozeno.Add(kartaB);
                } 
                else
                {
                    vylozeno.Add(kartaB);
                    vylozeno.Add(kartaA);

                }

                vysledek = kartaA.SrovnejS(kartaB);

                if (vysledek == Porovnani.DruhaMensi)
                {
                    Console.WriteLine("Bere hráč A\n");
                    //bereA
                    foreach (Karta karta in vylozeno)
                        _hracA.DejDospod(karta);
                }
                else if (vysledek == Porovnani.PrvniMensi)
                {
                    //bereB
                    Console.WriteLine("Bere hráč B\n");
                    foreach (Karta karta in vylozeno)
                        _hracB.DejDospod(karta);
                }

            }
        }
        public void VypisVysledek()
        {
            if (!JeKonec)
                Console.WriteLine("Hra ještě neskončila");
            else if (_hracA.PocetKaret == 0)
                Console.WriteLine("Vyhrál hráč B");
            else
                Console.WriteLine("Vyhrál hráč A");
        }
    }
}
