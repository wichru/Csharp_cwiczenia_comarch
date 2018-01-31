using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int szerokośćProstokąta, wysokośćProstokąta;

            Console.Write("Podaj szerokość prostokąta: ");
            szerokośćProstokąta = int.Parse(Console.ReadLine());

            Console.Write("Podaj wysokość prostokąta: ");
            wysokośćProstokąta = int.Parse(Console.ReadLine());

            // pętla uruchamiająca
            for (int i = 0; i < szerokośćProstokąta; i++)
            { 
                for (int k = 0; k < wysokośćProstokąta; k++)  // dodatkowa pętla w pętli po to żeby rysowało w pionie i poziomie
                {
                    Console.Write("*"); // instrukcja co pętla ma napisać
                }
                Console.WriteLine(); // po każdej linii potrzebna jest nowa linia dla nowej pętli

            }
            Console.ReadKey();
        }
    }
}
