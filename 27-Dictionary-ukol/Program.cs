using System;
using System.Collections.Generic;

namespace _27_Dictionary_ukol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadávej slova, a překlady, já si je budu ukládat");
            Console.WriteLine("Učení ukončíš příkazem . místo slova, pak budu fungovat jako slovník");

            Dictionary<string, string> slovnik = new Dictionary<string, string>();
            while (true)
            {
                Console.Write("Česky: ");
                string cesky = Console.ReadLine();
                if (cesky == ".")
                    break;
                else if (slovnik.ContainsKey(cesky))
                {
                    Console.WriteLine("To už mám uloženo, další.");
                }
                else
                {
                    Console.Write("Anglicky: ");
                    string anglicky = Console.ReadLine();
                    slovnik.Add(cesky, anglicky);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Teď jsem slovník");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Co chceš přeložit: ");
                string cesky = Console.ReadLine();
                if (cesky == ".")
                    break;
                else if (slovnik.ContainsKey(cesky))
                {
                    Console.WriteLine(slovnik[cesky]);
                }
                else
                {
                    Console.WriteLine("To neznám.");
                }
            }

            Console.WriteLine("Na přeloženou příště!");

        }
    }
}
