using System;

namespace ExString
{
    class App
    {
        static void Main(string[] args)
        {
            //Nome e sobrenome
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine ($"Nome e sobrenome: {nome} {sobrenome}");

            //Iniciais Maíusculas
            string inicialNome = nome.Substring(0,1);
            string inicialSobrenome = sobrenome.Substring(0,1);

            string nomeMaiusucula = inicialNome.ToUpper();
            string sobrenomeMaiuscula = inicialSobrenome.ToUpper();

            //Contagem
            int contagemNome = nome.Length;
            int contagemSobrenome = sobrenome.Length;

            int comprimento = contagemNome + contagemSobrenome;

            //Nome secreto
            int meioNome = nome.Length / 2;
            string primeiraMetadeNome = nome.Substring(0, meioNome);
            int primeiraMetadeSobrenome = sobrenome.Length / 2;
            string segundaMetadeSobrenome = sobrenome.Substring(primeiraMetadeSobrenome);
            string nomeSecreto = $"{primeiraMetadeNome} {segundaMetadeSobrenome}";          
   
            //Saída
            Console.WriteLine($"Iniciais e contagem: {nomeMaiusucula}.{sobrenomeMaiuscula} ({comprimento})");
            Console.WriteLine($"Nome secreto: {nomeSecreto}");
        }
    }
}
