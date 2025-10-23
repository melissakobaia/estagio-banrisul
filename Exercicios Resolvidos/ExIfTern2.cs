using System;

namespace ExIfTern2
{
    class Program
    {
        static void Main()
        {
            //Entrada
            Console.Write("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Digite a categoria do cliente (VIP, Ouro, Prata ou Bronze): ");
            //string categoriaCliente = Console.ReadLine().Trim();
            string categoriaCliente = Console.ReadLine();


            //Regras de desconto
            double desconto =

                categoriaCliente.Equals("VIP", StringComparison.OrdinalIgnoreCase) ? 35 :
                categoriaCliente.Equals("Ouro", StringComparison.OrdinalIgnoreCase) ? 25 :
                categoriaCliente.Equals("Prata", StringComparison.OrdinalIgnoreCase) ? 10:
                categoriaCliente.Equals("Bronze", StringComparison.OrdinalIgnoreCase) ? 5:
                0;

            //Calculo desconto
            double percentualRestante = 1 - (desconto / 100);

            double precoDesconto = preco * percentualRestante;

            //Saida
            Console.WriteLine($"Preço final com desconto: R${precoDesconto.ToString("F2")}");
            Console.WriteLine($"Desconto aplicado: {desconto}%");
            Console.WriteLine($"Categoria do cliente: {categoriaCliente}");
        }
    }
}
