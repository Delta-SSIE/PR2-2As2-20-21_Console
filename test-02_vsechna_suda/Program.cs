using System;
using System.Linq;

namespace test_02_vsechna_suda
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] cisla1 = { 0, 1, 2, 4, 6, 8 };
            int[] cisla2 = { 0, 2, 4, 6, 8 };
            int[] cisla3 = { };

            SudaCisla Even = new SudaCisla();

            Console.WriteLine( "Metoda 1:");
            Console.WriteLine( "{0}, {1}, {2}", Even.VsechnaSuda(cisla1), Even.VsechnaSuda(cisla2), Even.VsechnaSuda(cisla3));
            Console.WriteLine();

            Console.WriteLine("Metoda 2:");
            Console.WriteLine("{0}, {1}, {2}", Even.VsechnaSuda2(cisla1), Even.VsechnaSuda2(cisla2), Even.VsechnaSuda2(cisla3));
            Console.WriteLine();

            Console.WriteLine("Metoda 3:");
            Console.WriteLine("{0}, {1}, {2}", Even.VsechnaSuda3(cisla1), Even.VsechnaSuda3(cisla2), Even.VsechnaSuda3(cisla3));
            Console.WriteLine();

            Console.WriteLine("Metoda 4:");
            Console.WriteLine("{0}, {1}, {2}", Even.VsechnaSuda4(cisla1), Even.VsechnaSuda4(cisla2), Even.VsechnaSuda4(cisla3));
            Console.WriteLine();
        }



    }
}
