using System;

namespace _008_Exception_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int citatel = 5;
            Console.Write("Zadej jmenovatele: ");         

            int jmenovatel;
            try
            {
                jmenovatel = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Neplatný vstup, ukončuji program.");
                return;
            }

            try
            { 
                int podil = citatel / jmenovatel;
                Console.WriteLine($"Podíl je {podil}.");
            }
            catch
            {
                Console.WriteLine("Nulou nelze dělit");
            }


        }
    }
}
