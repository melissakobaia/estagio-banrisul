using System;

namespace ExEstruturasCondicionais
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite uma nota de 0 a 10: ");

            double nota = double.Parse(Console.ReadLine());

            string conceito = 

                nota >= 9 ? "A":
                nota >= 7 ? "B":
                nota >= 5 ? "C":
                "D";

            Console.WriteLine($"Conceito: {conceito}");
        }
    }
}
