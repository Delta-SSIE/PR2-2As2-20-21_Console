using System;

namespace _01_Class_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Reporter rep = new Reporter();
            //rep.Loguj("Hello World!");
            //rep.Loguj("NO nazdar!");

            Input input = new Input();
            int firstNum = input.ReadInt("Zadej první číslo (celé)");
            int secondNum = input.ReadInt("Zadej druhé číslo (celé)");

            double desetinne = input.ReadDouble("A teď jedno desetinné");
            

            if (firstNum > secondNum)
                Console.WriteLine("První je větší");
            else if (firstNum < secondNum)
                Console.WriteLine("Druhé je větší");
            else
                Console.WriteLine("Obě jsou stejná");
        }
    }
}
