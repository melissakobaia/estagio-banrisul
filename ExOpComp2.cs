using System;

namespace ExOpComp2
{
    class App
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma senha: "); 
            string senhaDigitada = Console.ReadLine();

            const string senha = "Senha123";

            Console.WriteLine($"Senha é válida? {senhaDigitada == senha}");
        }
    }
}

