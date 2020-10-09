﻿using System;

namespace _010_OOP_uvod_demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Kruznice k;
                k = new Kruznice();
                //k.NastavPolomer(-1); 
                k.NastavPolomer(1);

                //Console.WriteLine(k.Plocha());
                //Console.WriteLine(k.Obvod());

                Console.WriteLine("Kružnice o poloměru {0} má obvod {1}", k.VratPolomer(), k.Obvod());

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
