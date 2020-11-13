using System;

namespace _018_Kbeliky
{
    class Program
    {
        static void Main(string[] args)
        {
            Nadoba trilitrak = new Nadoba(3);
            Nadoba petilitrak = new Nadoba(5);

            petilitrak.Napln();
            petilitrak.PrelejDo(trilitrak);
            trilitrak.Vylij();
            petilitrak.PrelejDo(trilitrak);
            petilitrak.Napln();
            petilitrak.PrelejDo(trilitrak);

            Console.WriteLine(petilitrak);

            Console.ReadKey();
        }
    }
}
