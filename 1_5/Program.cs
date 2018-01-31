using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cyfra;

            Console.WriteLine("Podaj cyfre");
            cyfra = int.Parse(Console.ReadLine());

            switch (cyfra)
            {
                case 1: Console.WriteLine("Jeden"); break;
                case 2: Console.WriteLine("Dwa"); break;
                case 3: Console.WriteLine("Trzy"); break;
                case 4: Console.WriteLine("Cztery"); break;
                case 5: Console.WriteLine("Pięć"); break;
                case 6: Console.WriteLine("Sześć"); break;
                default: Console.WriteLine("Aż do tylu nie chciało mi się pisać"); break;
            }
            Console.ReadKey();
        }
    }
}
