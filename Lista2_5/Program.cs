using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a base do retângulo: ");
            double @base = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            double altura = double.Parse(Console.ReadLine());

            double area = @base * altura;
            Console.WriteLine("Área: " + area);

            if (area > 100)
            {
                Console.WriteLine("Terreno grande");
            }
            else
            {
                Console.WriteLine("Terreno pequeno");
            }
        }
    }
}
