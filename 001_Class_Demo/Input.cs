using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Class_Demo
{
    class Input
    {
    /// <summary>
    /// Metoda načítá celé číslo z klávesnice, při chybě opakuje načítání
    /// </summary>
    /// <param name="vyzva">Text, který se má zobrazit</param>
    /// <returns>Parsovaný vstup</returns>
        public int ReadInt(string vyzva)
        {
            Console.Write(vyzva + ": ");
            string retezec = Console.ReadLine();
            int vysledek;
            while (!int.TryParse(retezec, out vysledek))
            {
                Console.WriteLine("Neplatný vstup.");
                Console.Write(vyzva + ": ");
                retezec = Console.ReadLine();
            }
            return vysledek;
        }

        /// <summary>
        /// Metoda načítá desetinné číslo z klávesnice, při chybě opakuje načítání
        /// </summary>
        /// <param name="vyzva">Text, který se má zobrazit</param>
        /// <returns>Parsovaný vstup</returns>
        public double ReadDouble(string vyzva)
        {
            Console.Write(vyzva + ": ");
            string retezec = Console.ReadLine();
            double vysledek;
            while (!double.TryParse(retezec, out vysledek))
            {
                Console.WriteLine("Neplatný vstup.");
                Console.Write(vyzva + ": ");
                retezec = Console.ReadLine();
            }
            return vysledek;
        }

    }
}
