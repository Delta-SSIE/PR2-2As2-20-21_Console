using System;

namespace _009_Exceptions_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int citatel = 5;
            Console.Write("Zadej jmenovatele: ");

            try
            {                
                int jmenovatel = int.Parse(Console.ReadLine());
                int podil = citatel / jmenovatel;
                Console.WriteLine($"Podíl je {podil}.");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Nebylo zadáno platné číslo, nelze pokračovat.");
                Console.WriteLine("Původní zpráva je: \"{0}\"", e.Message);
            }
            catch (DivideByZeroException e)
            { 
                Console.WriteLine("Nulou nelze dělit, ukončuji.");
                Console.WriteLine("Původní zpráva je: \"{0}\"", e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Došlo k neznámé chybě, volejte Houston.");
            }

        }
    }
}
