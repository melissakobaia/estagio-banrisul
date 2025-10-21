using System;

namespace ExEstRepeti
{
    class App
    {
        static void Main()
        {
            int numero = new Random().Next(1, 11);
            int tentativas = 0;

            while (true)
            {
                Console.WriteLine("Escolha um número de 1 até 10: ");
                int numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                tentativas++;
            
                if(numeroEscolhido == numero)
                {
                    Console.WriteLine($"Parabéns! Você acertou o número e precisou de {tentativas} tentativas");
                    break;
                }
                else
                {
                    Console.WriteLine("Você errou, tente novamente.");
                    if(numeroEscolhido > numero )
                    {
                        Console.WriteLine("O número secreto é menor!");
                    } else
                    {
                        Console.WriteLine("O número secreto é maior!");
                    }
                }
            }
        }
    }
}