using _01_Class_Demo;
using System;

namespace _004_kvadrovnice
{
    class Program
    {
        static void Main(string[] args)
        {
            // D = b ^ 2 - 4 * a * c
            // x12 = (-b ± sqrt(D)) / 2a

            Input input = new Input();
            double a = input.ReadDouble("Zadej koeficient a");
            double b = input.ReadDouble("Zadej koeficient b");
            double c = input.ReadDouble("Zadej koeficient c");
            
            double D = b * b - 4 * a * c;

            if (a == 0)
            {
                Console.Write($"Rovnice {a}.x^2 + {b}.x + {c} = 0 není kvadratická. ");
                if (b != 0)
                    Console.WriteLine($"Jejím kořenem je {-b/c}");
                else
                    Console.WriteLine($"Žádné kořeny nemá.");
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Rovnice {a}.x^2 + {b}.x + {c} = 0 má dvojnásobný kořen {x}.");
            } 
            else if (D >= 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);

                Console.WriteLine($"Kořeny rovnice {a}.x^2 + {b}.x + {c} = 0 jsou {x1} a {x2}.");
            }
            else
            {
                Console.WriteLine($"Rovnice {a}.x^2 + {b}.x + {c} = 0 nemá žádný kořen.");
            }


        }
    }
}
