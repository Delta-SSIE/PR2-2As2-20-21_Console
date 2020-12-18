using System;
using System.Collections.Generic;

namespace _24_Bludiste_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, char[]> bludiste = new Dictionary<char, char[]>();
            bludiste.Add('A', new char[] { 'E', 'M' });
            bludiste.Add('B', new char[] { 'E', 'Š', 'T' });
            bludiste.Add('C', new char[] { 'E', 'Ň', 'U' });
            bludiste.Add('Č', new char[] { 'I', 'Q', 'W' });
            bludiste.Add('D', new char[] { 'G', 'K', 'Z' });
            bludiste.Add('Ď', new char[] { 'M', 'R', 'X' });
            bludiste.Add('E', new char[] { 'A', 'B', 'C' });
            bludiste.Add('Ě', new char[] { 'L', 'V', 'Y' });
            bludiste.Add('F', new char[] { 'F', 'H', 'S' });
            bludiste.Add('G', new char[] { 'D', 'K', 'U' });
            bludiste.Add('H', new char[] { 'F', 'Ň', 'S' });
            bludiste.Add('I', new char[] { 'Č', 'N', 'W' });
            bludiste.Add('J', new char[] { 'Š', 'T', 'Ť' });
            bludiste.Add('K', new char[] { 'D', 'G', 'Z' });
            bludiste.Add('L', new char[] { 'Ě', 'V', 'Y' });
            bludiste.Add('X', new char[] { 'Ď', 'O', 'R' });
            bludiste.Add('Y', new char[] { 'Ě', 'L', 'Ř' });
            bludiste.Add('M', new char[] { 'A', 'Ď', 'O' });
            bludiste.Add('N', new char[] { 'I', 'P', 'Q' });
            bludiste.Add('Ň', new char[] { 'C', 'H', 'S' });
            bludiste.Add('O', new char[] { 'M', 'R', 'X' });
            bludiste.Add('P', new char[] { 'N', 'U', 'Ž' });
            bludiste.Add('Q', new char[] { 'Č', 'N', 'W' });
            bludiste.Add('R', new char[] { 'Ď', 'O', 'X' });
            bludiste.Add('Ř', new char[] { 'V', 'Y', 'Ž' });
            bludiste.Add('S', new char[] { 'F', 'H', 'Ň' });
            bludiste.Add('Š', new char[] { 'B', 'J', 'Ť' });
            bludiste.Add('T', new char[] { 'B', 'J', 'Ť' });
            bludiste.Add('Ť', new char[] { 'J', 'Š', 'T' });
            bludiste.Add('U', new char[] { 'C', 'G', 'P' });
            bludiste.Add('V', new char[] { 'Ě', 'L', 'Ř' });
            bludiste.Add('W', new char[] { 'Č', 'I', 'Q' });
            bludiste.Add('Z', new char[] { 'D', 'K', 'Z' });
            bludiste.Add('Ž', new char[] { 'P', 'Ř' });

            //piš si ke každému rozcestí, v kolikátém kroku ses sem dostal
            Dictionary<char, byte> kroky = new Dictionary<char, byte>();

            //dávej si do fronty všechna rozcestí, kde jsi ještě nebyl, abys je později mohl projít
            Queue<char> kamJit = new Queue<char>();

            char start = 'A';
            char cil = 'Ž';

            kamJit.Enqueue(start); //aby bylo odkud začít, inicializuju frontu
            kroky[start] = 0; //na startu jsem hned

            while (kamJit.Count > 0) //dokud je ještě neprozkoumaná křižovatka
            {
                char rozcesti = kamJit.Dequeue(); //vezmi prvni rozcesti z fronty
                                
                if (rozcesti == cil)
                    break; //jsem na konci

                byte krok = kroky[rozcesti]; //kolikatym krokem jsem se sem dostal
                krok++; //do rozcesti okolo je to o krok dal

                //projdi všechny odbočky
                foreach (char pristi in bludiste[rozcesti])
                {
                    //když jsem tam už byl, přeskočím
                    if (kroky.ContainsKey(pristi))
                        continue;

                    //jinak si zapíšu nové rozcestí
                    //kroky.Add(pristi, krok); //nebo
                    kroky[pristi] = krok;

                    //a přidám odbočky do fronty
                    kamJit.Enqueue(pristi);
                }
            }

            if(!kroky.ContainsKey(cil))
            {
                Console.WriteLine("Cíl nenalezen!");
                return;
            }

            //musím zpět od cíle hledat, kudy se tam šlo - kudy klesá uložený počet kroků

            char pozice = cil;
            List<char> cesta = new List<char>();
            cesta.Add(cil);

            while (pozice != start)
            {
                //kolikatym krokem se sem šlo
                byte krok = kroky[pozice];

                //projdu všechny odbočky
                foreach (char soused in bludiste[pozice])
                {
                    //když najdu souseda s nižším počtem kroků, to je moje cesta
                    if (kroky[soused] == krok - 1)
                    {
                        cesta.Add(soused); //zapíšu si do cesty
                        pozice = soused; //přesunu se tam
                        break; //ukončím hledání sousedů
                    }
                }
            }

            cesta.Reverse();

            foreach(char misto in cesta)
                Console.Write(misto);

        }
    }
}
