using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int punkty;

            for (; ; ) // pętla dzięki której program po naciśnięciu ENTER uruchamia się cały czas
            {


                Console.WriteLine("Wpisz punkty które uzyskałeś: ");
                punkty = int.Parse(Console.ReadLine());

                if (punkty <= 50)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NDST");


                }
                if ((punkty >= 51) && (punkty <= 63))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("dst");

                }
                if ((punkty >= 64) && (punkty <= 76))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("db");

                }
                if ((punkty >= 77) && (punkty <= 90))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("bdb");

                }
                if ((punkty >= 91) && (punkty <= 100))
                {
                    Console.WriteLine("CEL");
                }
                Settings();
            }
        }

        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
    }
}
