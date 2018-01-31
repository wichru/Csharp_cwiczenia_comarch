using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba, początekPrzedziału, koniecPrzedziału;
            bool czyPierwsza;

            Console.Write("Podaj początek przedziału: ");
            początekPrzedziału = int.Parse(Console.ReadLine());

            Console.Write("Podaj koniec przedziału: ");
            koniecPrzedziału = int.Parse(Console.ReadLine());

            for (liczba = początekPrzedziału; liczba <= koniecPrzedziału; liczba++ ) // początek przedziału to LICZBA inicjująca pętle, sprawdzenie nie może być większe niż koniec przedziału
            {
                czyPierwsza = true; // fakowe inicjowanie, sprawdzenie, czy kolejna liczba jest pierwsza
                for (int i = 2; i < liczba; i++) 
                {
                    if (liczba % i == 0)
                    {
                        czyPierwsza = false;
                        break;
                    }
                }
                if (czyPierwsza) Console.WriteLine(liczba);
                
            }
            Console.ReadKey();
        }
    }
}
