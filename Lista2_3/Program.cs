using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            double n3 = double.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("Maior: " + n1);
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("Maior: " + n2);
            }
            else if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine("Maior: " + n3);
            }
            else if (n1 == n2 && n1 > n3)
            {
                Console.WriteLine("Maiores: " + n1 + " e " + n2);
            }
            else if (n1 == n3 && n1 > n2)
            {
                Console.WriteLine("Maiores: " + n1 + " e " + n3);
            }
            else if (n2 == n3 && n2 > n1)
            {
                Console.WriteLine("Maiores: " + n2 + " e " + n3);
            }
            else
            {
                Console.WriteLine("Todos os números são idênticos: " + n1);
            }
        }
    }
}