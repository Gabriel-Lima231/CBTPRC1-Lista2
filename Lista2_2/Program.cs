using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double n2 = double.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("Maior: " + n1);
            }
            else if (n2 > n1)
            {
                Console.WriteLine("Maior: " + n2);
            }
            else
            {
                Console.WriteLine("Os números são idênticos.");
            }
        }
    }
}
