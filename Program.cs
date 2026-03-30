using System;
using System.Text.RegularExpressions;

namespace ex035
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis locais
            double valor1, valor2;

            Console.Clear();

            Console.Write("Informe o primeiro valor: ");
            while (!double.TryParse(Console.ReadLine(), out valor1))
            {
                Console.Clear();
                Console.Write("\nValor incorreto. Por favor, tente novamente.\nInforme o primeiro valor: ");
            }

            Console.Write("Informe o segundo valor: ");
            while (!double.TryParse(Console.ReadLine(), out valor2))
            {
                Console.Clear();
                Console.Write("\nValor incorreto. Por favor, tente novamente.\nInforme o segundo valor: ");
            }

            Console.WriteLine($"O resultado da soma entre {valor1} + {valor2} = {Math.Round(valor1 + valor2, 2)}");
        }
    }
}
