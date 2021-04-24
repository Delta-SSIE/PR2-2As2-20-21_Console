using System;

namespace _29_Statika_Pocitadlo
{

    class Pocitadlo 
    { 
        private static int pocet = 0; 
        public Pocitadlo() { pocet++; } 
        public static void Kolik() 
        { 
            Console.WriteLine(pocet); 
        } 
    }


    class Program
    {
        static void Main(string[] args)
        {
            Pocitadlo.Kolik(); //vypíše 0
            Pocitadlo p = new Pocitadlo();
            Pocitadlo.Kolik(); //vypíše 1
            Pocitadlo q = new Pocitadlo();
            Pocitadlo.Kolik(); //vypíše 2
            Console.Read();
        }
    }


}
