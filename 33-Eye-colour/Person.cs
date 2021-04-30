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
        public Person(Sex sex, Colour gene1, Colour gene2)
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
            Console.WriteLine($"Genes: {blueGenes} blue : {brownGenes} brown ({((double)blueGenes)/people.Length} : {((double)brownGenes) / people.Length}) ");
            Console.WriteLine($"Eyes: {blueEyes} blue : {brownEyes} brown ({((double)blueEyes) /people.Length} : {((double)brownEyes) / people.Length}) ");
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


        private static Person[] SetPopulation(int count, double blueGeneRatio)
        {
            throw new NotImplementedException();
        }

        private static Person[] NextGeneration(Person[] oldGeneration, double averageKidsPerPair)
        {
            throw new NotImplementedException();
        }
    }
}
