using System;
using System.Collections.Generic;

namespace _22_Prebijena
{
    class Program
    {
        static void Main(string[] args)
        {
            //pravidla hry

            //rozdá se balíček karet napůl oběma hráčům
            //každý nese horní kartu
            //kdo má větší, bere obě a dává dospod

            //vyhrává ten, kdo obere soupeře o všechny


            /* test porovnání */
            //Karta dva = new Karta(VyskaKarty.Desitka, BarvaKarty.Kule);
            //Karta jedna = new Karta(VyskaKarty.Devitka, BarvaKarty.Srdce);
            ////Karta jedna = new Karta(VyskaKarty.Devitka, BarvaKarty.Kule);

            //if (jedna.SrovnejS(dva) == Porovnani.PrvniMensi)
            //{
            //    Console.WriteLine($"{jedna} je menší než {dva}");
            //}
            //else if (jedna.SrovnejS(dva) == Porovnani.ObeStejne)
            //{
            //    Console.WriteLine($"{jedna} je stejně vysoká jako {dva}");
            //}
            //else
            //{
            //    Console.WriteLine($"{jedna} je vyšší než {dva}");
            //}


            /* Ukázka fronty */
            //Queue<int> fronta = new Queue<int>();

            //fronta.Enqueue(5);
            //fronta.Enqueue(12);
            //fronta.Enqueue(-7);

            //int cislo = fronta.Dequeue();
            //Console.WriteLine(cislo);

            ////Console.WriteLine(fronta.Count); //2 - fronta se zkrátila

            //cislo = fronta.Peek();
            //Console.WriteLine(cislo);

            //cislo = fronta.Dequeue();
            //Console.WriteLine(cislo);

            //cislo = fronta.Dequeue();
            //Console.WriteLine(cislo);

            ////cislo = fronta.Dequeue();//chyba - není kde brát
            ////Console.WriteLine(cislo);


            /* test balíčku */
            //Balicek paklik = new Balicek();
            //paklik.DejDospod(new Karta(VyskaKarty.Desitka, BarvaKarty.Kule));
            //paklik.DejDospod(new Karta(VyskaKarty.Eso, BarvaKarty.Srdce)); 
            //paklik.DejDospod(new Karta(VyskaKarty.Spodek, BarvaKarty.Zaludy));
            //paklik.DejDospod(new Karta(VyskaKarty.Osma, BarvaKarty.Kule));

            //Console.WriteLine(paklik.VezmiKartu());

            //Console.WriteLine();

            //paklik.Napln();
            //paklik.Zamichej();

            //paklik.Vypis();

            Hra hra = new Hra();
            hra.Rozdej();
            while (!hra.JeKonec)
            {
                hra.Kolo();
            }
            hra.VypisVysledek();

        }
    }
}
