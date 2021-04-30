using System;

namespace _32_Obdelnik_a_ctverec
{
    class Program
    {
        static void Main(string[] args)
        {
            Ctverec ABCD = new Ctverec(10);
            Console.WriteLine(ABCD.Obsah());
            Console.WriteLine(ABCD.Strana);
            Console.WriteLine(ABCD.ToString());
        }
    }
}
