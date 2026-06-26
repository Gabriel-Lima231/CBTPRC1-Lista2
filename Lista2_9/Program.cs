using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite o sexo (F/M): ");
            string sexo = Console.ReadLine().ToUpper();

            Console.Write("Digite a altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double r = peso / (altura * altura);

            if (sexo == "F")
            {
                if (r < 19)
                {
                    Console.WriteLine("Abaixo do peso");
                }
                else if (r >= 19 && r < 24)
                {
                    Console.WriteLine("Peso ideal");
                }
                else
                {
                    Console.WriteLine("Acima do peso");
                }
            }
            else if (sexo == "M")
            {
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
            else
            {
                Console.WriteLine("Sexo inválido.");
            }
        }
    }
}