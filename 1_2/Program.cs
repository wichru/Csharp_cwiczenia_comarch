using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int poczatekZakresu, koniecZakresu;

            Console.WriteLine("Podaj początkową liczbę: ");
            poczatekZakresu = int.Parse(Console.ReadLine()); // PARSE bo wcześniej jest zdefiniowany INT a tutaj będzie string

            Console.WriteLine("Podaj końcową liczbę: ");
            koniecZakresu = int.Parse(Console.ReadLine());

            for (int i = poczatekZakresu; i < koniecZakresu; i++)
                Console.WriteLine(i);
                Console.ReadKey();
        }
    }
}
