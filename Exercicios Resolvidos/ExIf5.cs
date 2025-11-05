using System;

namespace Ex4IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número (1-10): ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada do {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}
