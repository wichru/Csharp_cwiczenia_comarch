using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double wartosc;

            Console.WriteLine("Podaj kwotę: ");
            wartosc = double.Parse(Console.ReadLine());

            Console.WriteLine("USD: {0:0.00}", 3.11*wartosc);
            Console.WriteLine("EUR: {0:0.00}", 4.18*wartosc);
            Console.WriteLine("GBP: {0:0.00}", 5.01*wartosc);

            Console.ReadKey();
        }
    }
}
