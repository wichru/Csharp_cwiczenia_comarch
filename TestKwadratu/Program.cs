using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKwadratu
{
    class TestKwadratu
    {

        static void Main(string[] args)
            {
            int width, height;

            Console.Write("Podaj wysokość prostokąta: ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Podaj szerokość prostokąta: ");
            width = int.Parse(Console.ReadLine());

                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }

            //for (int i = 0; i < szerokośćProstokąta; i++)

            //    for (int k = 0; k < wysokośćProstokąta; k++)
            //    {
            //        Console.Write("*");
            //    }
            Console.ReadKey();
            }
        }
    }

