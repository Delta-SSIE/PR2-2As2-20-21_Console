using System;

namespace _005_Enum
{
    enum Obdobi:byte { Jaro, Leto, Podzim, Zima }

    class Program
    {
        static void Main(string[] args)
        {
            Obdobi chladne = Obdobi.Podzim;

            Console.WriteLine(chladne);
            chladne++;
            Console.WriteLine(chladne);
            chladne++;
            Console.WriteLine(chladne);

            Obdobi horke = (Obdobi)1;
            Console.WriteLine(horke);

            Obdobi divne = (Obdobi)3;

            Console.WriteLine(divne);
            divne += 252;
            Console.WriteLine(divne);
            divne++;
            Console.WriteLine(divne);

            Console.WriteLine((byte)Obdobi.Jaro + (byte)Obdobi.Podzim);

        }
    }
}
