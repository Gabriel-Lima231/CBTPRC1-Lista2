using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o lado A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado C: ");
            double c = double.Parse(Console.ReadLine());

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Forma um triângulo: Eqüilátero");
                }
                else if (a != b && b != c && a != c)
                {
                    Console.WriteLine("Forma um triângulo: Escaleno");
                }
                else
                {
                    Console.WriteLine("Forma um triângulo: Isósceles");
                }
            }
            else
            {
                Console.WriteLine("Os valores digitados não formam um triângulo.");
            }
        }
    }
}
