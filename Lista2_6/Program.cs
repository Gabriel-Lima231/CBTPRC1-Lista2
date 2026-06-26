using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double r = peso / (altura * altura);

            if (r < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (r >= 20 && r < 25)
            {
                Console.WriteLine("Peso ideal");
            }
            else
            {
                Console.WriteLine("Acima do peso");
            }
        }
    }
}