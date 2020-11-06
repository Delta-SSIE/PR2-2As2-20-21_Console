using System;

namespace _017_OOP_Ucet_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucet ucet = new Ucet("swordfish");
            ucet.Uloz(1000);
            if (ucet.Vyber(100, "swordfish"))
            {
                Console.WriteLine("Vybírám");
            }
            else
            {
                Console.WriteLine("Chyba při výběru. Zkontrolujte heslo.");
            }

            if (ucet.ZmenHeslo("swordfis", "NCC-1701"))
            {
                Console.WriteLine("Změna hesla úspěšná");
            }
            else
            {
                Console.WriteLine("Chyba při změně hesla");
            }

            if (ucet.Vyber(100, "NCC-1701")) //nepovede se - byla chyba při změně
            {
                Console.WriteLine("Vybírám");
            }
            else
            {
                Console.WriteLine("Chyba při výběru. Zkontrolujte heslo.");
            }


            if (ucet.ZmenHeslo("swordfish", "NCC-1701"))
            {
                Console.WriteLine("Změna hesla úspěšná");
            }
            else
            {
                Console.WriteLine("Chyba při změně hesla");
            }

            if (ucet.Vyber(100, "NCC-1701")) //povede se
            {
                Console.WriteLine("Vybírám");
            }
            else
            {
                Console.WriteLine("Chyba při výběru. Zkontrolujte heslo.");
            }

            Console.WriteLine(ucet.Log);
        }
    }
}
