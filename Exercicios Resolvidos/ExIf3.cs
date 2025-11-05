using System;

namespace TesteNovo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade <= 12)
            {
                Console.WriteLine("Classificação: Criança");
            }
            else if (idade <= 17)
            {
                Console.WriteLine("Classificação: Adolescente");
            }
            else if (idade <= 59)
            {
                Console.WriteLine("Classificação: Adulto");
            }
            else
            {
                Console.WriteLine("Classificação: Idoso");
            }
        }  
    }
}
