using System;
using System.Collections.Generic;
using System.Linq;

namespace _25_Bludiste_LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            Krizovatka A = new Krizovatka('A');
            Krizovatka B = new Krizovatka('B');
            Krizovatka C = new Krizovatka('C');
            Krizovatka Č = new Krizovatka('Č');
            Krizovatka D = new Krizovatka('D');
            Krizovatka Ď = new Krizovatka('Ď');
            Krizovatka E = new Krizovatka('E');
            Krizovatka Ě = new Krizovatka('Ě');
            Krizovatka F = new Krizovatka('F');
            Krizovatka G = new Krizovatka('G');
            Krizovatka H = new Krizovatka('H');
            Krizovatka I = new Krizovatka('I');
            Krizovatka J = new Krizovatka('J');
            Krizovatka K = new Krizovatka('K');
            Krizovatka L = new Krizovatka('L');
            Krizovatka X = new Krizovatka('X');
            Krizovatka Y = new Krizovatka('Y');
            Krizovatka M = new Krizovatka('M');
            Krizovatka N = new Krizovatka('N');
            Krizovatka Ň = new Krizovatka('Ň');
            Krizovatka O = new Krizovatka('O');
            Krizovatka P = new Krizovatka('P');
            Krizovatka Q = new Krizovatka('Q');
            Krizovatka R = new Krizovatka('R');
            Krizovatka Ř = new Krizovatka('Ř');
            Krizovatka S = new Krizovatka('S');
            Krizovatka Š = new Krizovatka('Š');
            Krizovatka T = new Krizovatka('T');
            Krizovatka Ť = new Krizovatka('Ť');
            Krizovatka U = new Krizovatka('U');
            Krizovatka V = new Krizovatka('V');
            Krizovatka W = new Krizovatka('W');
            Krizovatka Z = new Krizovatka('Z');
            Krizovatka Ž = new Krizovatka('Ž');

            A.PridejCestu(E);
            B.PridejCestu(E);
            C.PridejCestu(E);
            Č.PridejCestu(I);
            D.PridejCestu(G);
            Ď.PridejCestu(M);
            E.PridejCestu(A);
            Ě.PridejCestu(L);
            F.PridejCestu(F);
            G.PridejCestu(D);
            H.PridejCestu(F);
            I.PridejCestu(Č);
            J.PridejCestu(Š);
            K.PridejCestu(D);
            L.PridejCestu(Ě);
            X.PridejCestu(Ď);
            Y.PridejCestu(Ě);
            M.PridejCestu(A);
            N.PridejCestu(I);
            Ň.PridejCestu(C);
            O.PridejCestu(M);
            P.PridejCestu(N);
            Q.PridejCestu(Č);
            R.PridejCestu(Ď);
            Ř.PridejCestu(V);
            S.PridejCestu(F);
            Š.PridejCestu(B);
            T.PridejCestu(B);
            Ť.PridejCestu(J);
            U.PridejCestu(C);
            V.PridejCestu(Ě);
            W.PridejCestu(Č);
            Z.PridejCestu(D);
            Ž.PridejCestu(P);

            A.PridejCestu(M);
            B.PridejCestu(Š);
            C.PridejCestu(Ň);
            Č.PridejCestu(Q);
            D.PridejCestu(K);
            Ď.PridejCestu(R);
            E.PridejCestu(B);
            Ě.PridejCestu(V);
            F.PridejCestu(H);
            G.PridejCestu(K);
            H.PridejCestu(Ň);
            I.PridejCestu(N);
            J.PridejCestu(T);
            K.PridejCestu(G);
            L.PridejCestu(V);
            X.PridejCestu(O);
            Y.PridejCestu(L);
            M.PridejCestu(Ď);
            N.PridejCestu(P);
            Ň.PridejCestu(H);
            O.PridejCestu(R);
            P.PridejCestu(U);
            Q.PridejCestu(N);
            R.PridejCestu(O);
            Ř.PridejCestu(Y);
            S.PridejCestu(H);
            Š.PridejCestu(J);
            T.PridejCestu(J);
            Ť.PridejCestu(Š);
            U.PridejCestu(G);
            V.PridejCestu(L);
            W.PridejCestu(I);
            Z.PridejCestu(K);
            Ž.PridejCestu(Ř);

            B.PridejCestu(T);
            C.PridejCestu(U);
            Č.PridejCestu(W);
            D.PridejCestu(Z);
            Ď.PridejCestu(X);
            E.PridejCestu(C);
            Ě.PridejCestu(Y);
            F.PridejCestu(S);
            G.PridejCestu(U);
            H.PridejCestu(S);
            I.PridejCestu(W);
            J.PridejCestu(Ť);
            K.PridejCestu(Z);
            L.PridejCestu(Y);
            X.PridejCestu(R);
            Y.PridejCestu(Ř);
            M.PridejCestu(O);
            N.PridejCestu(Q);
            Ň.PridejCestu(S);
            O.PridejCestu(X);
            P.PridejCestu(Ž);
            Q.PridejCestu(W);
            R.PridejCestu(X);
            Ř.PridejCestu(Ž);
            S.PridejCestu(Ň);
            Š.PridejCestu(Ť);
            T.PridejCestu(Ť);
            Ť.PridejCestu(T);
            U.PridejCestu(P);
            V.PridejCestu(Ř);
            W.PridejCestu(Q);
            Z.PridejCestu(Ž);

            Krizovatka start = A;
            Krizovatka cil = Ž;

            Queue<Krizovatka> kamJit = new Queue<Krizovatka>(); //vytvořím si frontu - seznam míst, kam by se to mělo prozkoumat
            kamJit.Enqueue(start); //dám si do ní start
            start.Krok = 0; //nastavím startovní křožovatce vzdálenost od startovní křižovatky na 0

            while(kamJit.Count > 0) //dokud je co prozkoumávat, pracuj
            {
                Krizovatka pozice = kamJit.Dequeue(); //vyndej první z fronty, ulož jako pozice

                if (pozice == cil) //jsi v cíli? skonči
                    break;

                foreach (Krizovatka soused in pozice.Odbocky) //projdi sousedy aktuální křožovatky
                {
                    if (soused.Krok != -1) //zde už jsem byl, vzdálenost není -1
                        continue; // nebudu nic dělat a jdu na další

                    //teď už vím, že jsem tu ještě neprozkoumával
                    soused.Krok = pozice.Krok + 1; //nastavím sousedovu vzdálenost od startu o 1 víc, než je moje teď

                    soused.Cesta = new List<Krizovatka>(pozice.Cesta); //zapíšu sousedovi cestu k němu jako cestu ke mně
                    soused.Cesta.Add(pozice); //přidám navíc svoji pozici

                    kamJit.Enqueue(soused); //přidám souseda na seznam věcí, které je třeba projít
                }

            }

            if (cil.Krok == -1) //cíl nebyl vůbec objeven - jeho vzdálenost není nastavena
            {
                Console.WriteLine("Cíl nenalezen!");
                return; //skončím
            }

            foreach(Krizovatka pozice in cil.Cesta) //vypíšu cestu k cíli
            {
                Console.Write(pozice.Popis);
            }
        }
    }
}
