using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Eye_colour
{
    enum Sex { Male, Female }
    enum Colour { Brown, Blue }
    class Person
    {
        private static Random random = new Random();
        private Person(Sex sex, Colour gene1, Colour gene2)
        {
            Sex = sex;
            Gene1 = gene1;
            Gene2 = gene2;
        }

        public Person(Person father, Person mother)
        {
            Sex = (Sex) random.Next(2);
            Gene1 = (random.Next(2) == 0) ? father.Gene1 : father.Gene2;
            Gene2 = (random.Next(2) == 0) ? mother.Gene1 : mother.Gene2;
        }

        public Sex Sex { get; private set; }
        public Colour Gene1 { get; private set; }
        public Colour Gene2 { get; private set; }

        public Colour Eyes 
        {
            //get 
            //{
            //    return (Gene1 == Gene2 && Gene1 == Colour.Blue) ? Colour.Blue : Colour.Brown;
            //}
            //lze zapsat také
            get => (Gene1 == Gene2 && Gene1 == Colour.Blue) ? Colour.Blue : Colour.Brown;
        }

        public static void ShowStats(Person[] people)
        {
            int blueGenes = getBlueGenes(people);
            int brownGenes = people.Length * 2 - blueGenes;
            int blueEyes = getBlueEyes(people);
            int brownEyes = people.Length - blueEyes;

            Console.WriteLine($"{people.Length} people, {getMales(people).Length} males, {getFemales(people).Length} females");
            Console.WriteLine($"Genes: {blueGenes} blue : {brownGenes} brown ({((double)blueGenes)/ brownGenes} : 1) ");
            Console.WriteLine($"Eyes: {blueEyes} blue : {brownEyes} brown ({((double)blueEyes) / brownEyes} : 1) ");
            Console.WriteLine();
        }

        private static Person[] getMales (Person[] people)
        {
            List<Person> boys = new List<Person>();
            foreach (Person person in people)
            {
                if (person.Sex == Sex.Male)
                    boys.Add(person);
            }
            return boys.ToArray();            
        }

        //nebo celou metodu zavedu takto:
        //private static Person[] getMales(Person[] people) => people.Where(x => x.Sex == Sex.Male).ToArray();


        //pro jednoduchost nebudu kopírovat, použiju zkrácený zápis
        private static Person[] getFemales (Person[] people) => people.Where(x => x.Sex == Sex.Female).ToArray();        

        private static int getBlueGenes(Person[] people)
        {
            int count = 0;
            foreach (Person person in people)
            {
                if (person.Gene1 == Colour.Blue)
                    count++;
                if (person.Gene2 == Colour.Blue)
                    count++;
            }
            return count;
        }
        //nebo
        //private static int getBlueGenes(Person[] people) => people.Where(x => x.Gene1 == Colour.Blue).Count() + people.Where(x => x.Gene2 == Colour.Blue).Count();

        private static int getBlueEyes(Person[] people)
        {
            int count = 0;
            foreach (Person person in people)
            {
                if (person.Eyes == Colour.Blue)
                    count++;
            }
            return count;
        }

        //opět alternativní zápis metody: 
        //private static int getBlueEyes(Person[] people) => people.Where(x => x.Eyes == Colour.Blue).Count();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="count">Population size</param>
        /// <param name="blueGeneRatio">Double between 0 and 1</param>
        /// <returns></returns>
        public static Person[] SetPopulation(int count, double blueGeneRatio)
        {
            Person[] population = new Person[count];
            for (int i = 0; i < count; i++)
            {
                Sex sex;
                if (random.Next(2) == 0) //vyrobí číslo 0 nebo 1
                    sex = Sex.Male;
                else
                    sex = Sex.Female;

                //nebo
                //Sex sex = (random.Next(2) == 0) ? sex = Sex.Male : sex = Sex.Female;

                Colour gene1;
                if (random.NextDouble() < blueGeneRatio) //vyrobí desetinné číslo mezi 0 a 1
                    gene1 = Colour.Blue;
                else
                    gene1 = Colour.Brown;


                //Colour gene1 = random.NextDouble() < blueGeneRatio ? Colour.Blue : Colour.Brown;

                Colour gene2 = random.NextDouble() < blueGeneRatio ? Colour.Blue : Colour.Brown;


                population[i] = new Person(sex, gene1, gene2);
            }
            return population;
        }

        public static Person[] NextGeneration(Person[] oldGeneration, double averageKidsPerPair)
        {
            //vytvořit sadu párů
            Person[] males = getMales(oldGeneration);
            Person[] females = getFemales(oldGeneration);

            males = males.OrderBy(x => random.NextDouble()).ToArray(); //náhodné pořadí
            females = females.OrderBy(x => random.NextDouble()).ToArray(); //náhodné pořadí

            int pairCount = Math.Min(males.Length, females.Length);


            //spočítám, kolik má být dětí
            int kidsCount = (int) Math.Round(pairCount * averageKidsPerPair);


            //pro každé dítě náhodně vyberu pár a vytvořím nového potomka
            Person[] nextGeneration = new Person[kidsCount];
            for (int i = 0; i < kidsCount; i++)
            {
                //vzít náhodný pár
                int pairIndex = random.Next(pairCount);
                Person father = males[pairIndex];
                Person mother = females[pairIndex];

                nextGeneration[i] = new Person(father, mother);
            }

            return nextGeneration;
        }
    }
}
