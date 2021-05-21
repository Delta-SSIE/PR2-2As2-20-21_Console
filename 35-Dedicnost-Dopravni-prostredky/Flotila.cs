using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Dedicnost_Dopravni_prostredky
{
    //Vytvořte uzavřenou třídu Flotila
    class Flotila
    {
        //Flotila bude mít nějakou formu úložiště, ve kterém si bude ukládat jednotlivá vozidla flotily
        private List<DopravniProstredek> vozidla;

        //bude mít veřejné vlastnosti (jen pro čtení) Velikost a Kapacita, které budou vracet, kolik vozidel ve flotile je a kolik lidí flotila uveze.
        public int Velikost
        {
            get
            {
                return vozidla.Count;
            }
        }
        
        public int Kapacita
        {
            get
            {
                //int kapacita = 0;
                //foreach (DopravniProstredek dp in vozidla)
                //{
                //    kapacita += dp.PocetMist;
                //}
                //return kapacita;

                return vozidla.Select(dp => dp.PocetMist).Sum();
            }
        }

        //bude mít veřejnou vlastnost Pohony (jen pro čtení), která bude vracet pole všech pohonů vozidel. Pozor, každý typ bude v poli nejvýše jednou, i kdyby jej mělo 10 vozidel
        public TypPohonu[] Pohony
        {
            get
            {
                //List<TypPohonu> seznam = new List<TypPohonu>();
                //foreach (DopravniProstredek dp in vozidla)
                //{
                //    if (!seznam.Contains(dp.Pohon))
                //        seznam.Add(dp.Pohon);
                //}
                //return seznam.ToArray();

                HashSet<TypPohonu> seznam = new HashSet<TypPohonu>();
                foreach (DopravniProstredek dp in vozidla)
                {
                    seznam.Add(dp.Pohon);
                }
                return seznam.ToArray();

                //return new HashSet<TypPohonu>(vozidla.Select(x => x.Pohon)).ToArray();
            }
        }

        public Flotila()
        {
            vozidla = new List<DopravniProstredek>();
        }
        
        //bude mít metodu PridejVozidlo (Vozidlo v), která přidá předané vozidlo do flotily
        public void PridejVozidlo(DopravniProstredek dp)
        {
            //pokud by přesně toto vozidlo ve flotile už bylo, pak vyvolá výjimku
            if (vozidla.Contains(dp))
            {
                throw new ArgumentException("Vozidlo už ve flotile je");
            }

            vozidla.Add(dp);
        }

        //(volitelně) bude mít také metodu OdeberVozidlo (Vozidlo v)
        public void OdeberVozidlo(DopravniProstredek dp)
        {
            vozidla.Remove(dp);
        }
        
        //bude mít veřejnou vlastnost Natankuj(), která natankuje všechna vozidla ve flotile
        public void Natankuj()
        {
            foreach (var dp in vozidla)
            {
                dp.Natankuj();
            }
        }

        //bude mít veřejnou metodu OdvezRychle(int pocetLidi), která vybere vozidla tak, aby daný počet lidí přepravila nejrychleji. Vypíše do konzole všechna použitá vozidla a také rychlost přesunu (předpokládáme, že celá flotila pojede rychlostí nejpomalejšího prvku). Pokud není možné lidi odvézt, metoda to také vypíše
        public void OdvezRychle(int pocetLidi)
        {

            if (pocetLidi > Kapacita)
            {
                Console.WriteLine("Nelze skupinu odvézt");
                return;
            }

            double rychlostPresunu = 0;

            var podleRychlosti = vozidla.OrderByDescending(dp => dp.MaxRychlost);
            foreach (DopravniProstredek dp in podleRychlosti)
            {
                if (pocetLidi <= 0)
                    break;

                Console.WriteLine(dp);
                rychlostPresunu = dp.MaxRychlost; //postupně snižuju rychlost přesunu
                pocetLidi -= dp.PocetMist;
            }

            Console.WriteLine($"Rcyhlost přesunu je {rychlostPresunu}");
        }
    }
}
