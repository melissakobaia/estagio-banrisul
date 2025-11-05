using System;

namespace ExIfNovo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 != 0)
            {
                Console.WriteLine("Impar");
            }
            else
            {
                Console.WriteLine("Par");
            }
        }
    }
}
 