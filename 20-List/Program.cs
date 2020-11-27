using System;
using System.Collections;
using System.Collections.Generic;

namespace _20_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //int cislo = 51;

            //List<int> delitele = new List<int>();

            //// vypis delitele
            //// projdi vsechna cisla od 1 do cislo
            //for (int i = 1; i <= cislo; i++)
            //{
            //    if (cislo % i == 0)
            //    {
            //        delitele.Add(i);
            //    }
            //}

            //for (int i = 0; i < delitele.Count; i++)
            //{
            //    Console.WriteLine(delitele[i]);
            //}

            //foreach (int delitel in delitele)
            //{
            //    Console.WriteLine($"Cislo {cislo} deli beze zbytku {delitel}.");
            //}

            List<string> nakoupit = new List<string>();
            nakoupit.Add("maslo");
            nakoupit.Add("chleba"); 
            nakoupit.Add("rohliky");
            nakoupit.Add("vejce");
            //nakoupit.Add("chleba");

            if (nakoupit.Contains("vejce"))
            {
                Console.WriteLine("Vejce tam už jsou");
            }
            else
            {
                Console.WriteLine("Vejce tam nejsou");
            }
            Console.WriteLine("Chleba se nachází na pozici {0}", nakoupit.IndexOf("chleba"));
            Console.WriteLine("Chleba se nachází na pozici {0}", nakoupit.LastIndexOf("chleba"));

            foreach (string polozka in nakoupit)
            {
                Console.WriteLine(polozka);
            }
            Console.WriteLine();

            nakoupit.Remove("rohliky");

            foreach (string polozka in nakoupit)
            {
                Console.WriteLine(polozka);
            }
            Console.WriteLine();

            nakoupit.Insert(1, "mineralka");
            nakoupit.Add("hrách");
            nakoupit.Add("lepidlo");
            nakoupit.Add("Salám");

            foreach (string polozka in nakoupit)
            {
                Console.WriteLine(polozka);
            }
            Console.WriteLine();

            nakoupit.Sort();
            nakoupit.Reverse();

            foreach (string polozka in nakoupit)
            {
                Console.WriteLine(polozka);
            }
            Console.WriteLine();

            string[] polePolozek = nakoupit.ToArray();
            Console.WriteLine(String.Join(", ", polePolozek));
        }
    }
}
