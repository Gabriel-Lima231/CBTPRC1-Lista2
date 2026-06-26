using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota P1: ");
            double p1 = double.Parse(Console.ReadLine());

            double p2Necessaria = (15 - p1) / 2;

            if (p2Necessaria < 0)
            {
                p2Necessaria = 0;
            }

            Console.WriteLine("Para ser aprovado, o aluno precisa tirar na P2 no mínimo: " + p2Necessaria.ToString("F2"));
        }
    }
}