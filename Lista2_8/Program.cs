using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor C: ");
            double c = double.Parse(Console.ReadLine());

            double a2 = a * a;
            double b2 = b * b;
            double c2 = c * c;

            if (a2 == b2 + c2 || b2 == a2 + c2 || c2 == a2 + b2)
            {
                Console.WriteLine("Os valores formam um triângulo retângulo.");
            }
            else
            {
                Console.WriteLine("Os valores não formam um triângulo retângulo.");
            }
        }
    }
}
