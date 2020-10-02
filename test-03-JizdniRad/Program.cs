using System;

namespace test_03_JizdniRad
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = 5;
            int minutes = 42;
            int interval = 13;

            while (hours < 8)
            {
                Console.WriteLine("{0:0}:{1:00}", hours, minutes);
                
                minutes += interval;
                if (minutes > 59)
                {
                    hours++;
                    minutes %= 60; // totéž, co minutes = minutes -60, resp. minutes -= 60;
                }
            }

            Console.WriteLine();
            // a nebo jinak

            int time = 5 * 60 + 42;
            while (time / 60 < 8)
            {
                Console.WriteLine("{0:0}:{1:00}", time / 60, time % 60);
                time += interval;
            }
        }
    }
}
