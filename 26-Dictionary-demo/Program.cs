using System;
using System.Collections.Generic;

namespace _26_Dictionary_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> slovnik = new Dictionary<string, string>();

            slovnik.Add("já", "me");
            slovnik.Add("ty", "you");
            slovnik["on"] = "he";

            Console.WriteLine(slovnik["já"]);

            Dictionary<int, string> byty = new Dictionary<int, string>();
            byty[1] = "Vomáčkovi";
            byty[2] = "Procházkovi";
            Console.WriteLine(byty[2]);

            if (byty.ContainsKey(3))
                Console.WriteLine(byty[3]);

            Dictionary<string, int[]> zaznamy = new Dictionary<string, int[]>();
            zaznamy["agent"] = new int[] { 1, 4, 12, -1 };


        }
    }
}
