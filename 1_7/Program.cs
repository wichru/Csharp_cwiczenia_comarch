using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilośćBanknotów, kwota;
            int[] banknoty = { 500, 200, 100, 50, 20, 10 };

            Console.WriteLine("Podaj kwotę wypłaty: ");
            kwota = int.Parse(Console.ReadLine());

            for (int i = 0; i < banknoty.Length; i++)
            {
                ilośćBanknotów = kwota / banknoty[i];
                Console.WriteLine("{0} PLN:{1}", banknoty [i], ilośćBanknotów);
                kwota = kwota - ilośćBanknotów * banknoty[i];
            }
            Console.ReadKey();
        }

    }
}
