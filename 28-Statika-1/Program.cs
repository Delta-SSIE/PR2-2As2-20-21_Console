using System;

namespace _28_Statika_1
{
    class Clovek {

        public string Name { get; set; }

        public void PopisMne()
        {
            Popis();
        }
        
        public static void Popis() 
        { 
            Console.WriteLine("Lidé jsou humaniodní rasa, ne nepodobná gorilám, vyznačují se ale nižší \n"
                + "inteligencí, fyzickou silou i celkovou odolností.Nejsou také schopni \n"
                + "artikulované řeči."); 
        } 
    }

    class Program 
    { 
        static void Main(string[] args) 
        { 
            Clovek.Popis();

            Clovek franta = new Clovek();
            franta.Name = "František";

            ABC(5, 4);
            
            Console.Read(); 
        } 

        static int ABC(int cislo1, int cislo2)
        {
            return cislo2 - cislo1;
        }
    }

}
