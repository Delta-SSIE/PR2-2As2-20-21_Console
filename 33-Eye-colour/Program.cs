using System;

namespace _33_Eye_colour
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] population = Person.SetPopulation(1000, 0.2);
            double kidsPerPair = 2.06;

            for (int i = 0; i < 80; i++)
            {
                Console.WriteLine( $"Generation {i}");
                Person.ShowStats(population);
                population = Person.NextGeneration(population, kidsPerPair);
            }
        }
    }
}
