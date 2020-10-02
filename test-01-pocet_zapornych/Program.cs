using System;

namespace test_01_pocet_zapornych
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadávej čísla, ukonči příkazem \"end\".");
            
            int negative = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                    break;

                // double num = Convert.ToDouble(input);
                
                if (!double.TryParse(input, out double num)) {
                    Console.WriteLine("To není číslo");
                    continue;
                }

                if (num < 0)
                    negative++;
            }

            Console.WriteLine($"Bylo zadáno {negative} záporných čísel.");
        }
    }
}
