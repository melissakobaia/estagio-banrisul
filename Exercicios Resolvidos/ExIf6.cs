using System;

namespace ExIf5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            //Contador
            int contadorVogais = 0;
            int contadorConsoantes = 0;

            //Método contador
            foreach (char caracter in frase)
            {
                char caracterMinusculo = Char.ToLower(caracter);

                switch (caracterMinusculo)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        contadorVogais++;
                        break;

                    default:

                        if (Char.IsLetter(caracterMinusculo))
                        {
                            contadorConsoantes++;
                        }
                        break;
                }
            }
            //Saída
            Console.WriteLine($"Vogais: {contadorVogais}");
            Console.WriteLine($"Consoantes: {contadorConsoantes}");
        }
    }
}
