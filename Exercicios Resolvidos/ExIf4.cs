using System;

namespace ExIf3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número (1-7): ");
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Dia: Segunda-feira");
                    Console.WriteLine("Tipo: Dia útil");
                    break;
                case 2:
                    Console.WriteLine("Dia: Terça-feira");
                    Console.WriteLine("Tipo: Dia útil");
                    break;
                case 3:
                    Console.WriteLine("Dia: Quarta-feira");
                    Console.WriteLine("Tipo: Dia útil");
                    break;
                case 4:
                    Console.WriteLine("Dia: Quinta-feira");
                    Console.WriteLine("Tipo: Dia útil");
                    break;
                case 5:
                    Console.WriteLine("Dia: Sexta-feira");
                    Console.WriteLine("Tipo: Dia útil");
                    break;
                case 6:
                    Console.WriteLine("Dia: Sábado");
                    Console.WriteLine("Tipo: Final de semana");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    Console.WriteLine("Tipo: Final de semana");
                    break;
                default:
                    Console.WriteLine("Dia inválido");
                    break;
            }
        }
    }
}
