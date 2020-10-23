using System;

namespace _015_Kruznice_s_vlastnostmi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Kruznice k = new Kruznice(1);
                
                Kruznice l = new Kruznice();
                l.Polomer = 7;

                Kruznice m = new Kruznice();

                Console.WriteLine($"Kružnice o poloměru {k.Polomer} má obvod {k.Obvod} a obsah {k.Obsah}");
                Console.WriteLine($"Kružnice o poloměru {l.Polomer} má obvod {l.Obvod} a obsah {l.Obsah}");
                Console.WriteLine($"Kružnice o poloměru {m.Polomer} má obvod {m.Obvod} a obsah {m.Obsah}");

            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Nepovolená hodnota parametru.");
            }
            catch (Exception)
            {
                Console.WriteLine("Došlo k závažné chybě programu.");
            }
        }
    }
}
