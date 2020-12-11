using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22_Prebijena
{
    class Balicek
    {
        //Úložiště karet
        private Queue<Karta> _karty = new Queue<Karta>();

        //Počet karet v balíku
        public int PocetKaret
        {
            get { return _karty.Count; }
        }


        //Naplň = Vytvoř všechny karty
        public void Napln()
        {
            _karty.Clear(); //vyprázdním, pokud by tam něco bylo

            for (byte vyska = 0; vyska < 8; vyska++)
            {
                for (byte barva = 0; barva < 4; barva++ )
                {
                    _karty.Enqueue(new Karta( (VyskaKarty) vyska, (BarvaKarty) barva));
                }
            }
        }

        //Zamíchej
        public void Zamichej()
        {
            Random rnd = new Random();
            Karta[] tmpKarty = _karty.ToArray();
            tmpKarty = tmpKarty.OrderBy(i => rnd.NextDouble()).ToArray();
            _karty = new Queue<Karta>(tmpKarty);
        }


        //Vezmi horní kartu
        public Karta VezmiKartu()
        {
            return _karty.Dequeue();
        }

        //Dej kartu dospod
        public void DejDospod(Karta karta)
        {
            _karty.Enqueue(karta);
        }

        //Vypis karty
        public void Vypis()
        {
            foreach(Karta karta in _karty)
            {
                Console.WriteLine(karta);
            }
        }
    }
}
