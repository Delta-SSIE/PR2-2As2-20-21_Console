using System;

namespace _006_Enum_Karty
{
    enum Barva { Srdce, Kary, Piky, Krize, Trefy = Krize };

    class Program
    {
        static void Main(string[] args)
        {
            Barva moje = Barva.Krize;
            Barva tvoje = Barva.Trefy;
            if (moje == tvoje)
                Console.WriteLine("Máme stejnou barvu");
            else
                Console.WriteLine("Každý máme jinou barvu");
        }
    }
}
