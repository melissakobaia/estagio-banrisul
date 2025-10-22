using System;

namespace ExAritm
{
    class App
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o primeiro número:");
            string primeiroNumero = Console.ReadLine();
            double primeiroNumeroArm= Double.Parse(primeiroNumero);

            Console.Write("Digite o segundo número:");
            string segundoNumero = Console.ReadLine();
            double segundoNumeroArm = Double.Parse(segundoNumero);

            //Somar
            double Soma = primeiroNumeroArm + segundoNumeroArm;
            Console.WriteLine("Soma: "+Soma);

            //Subtrair
            double Subtrair = primeiroNumeroArm - segundoNumeroArm;
            Console.WriteLine("Subtração: "+Subtrair);

            //Multiplicação
            double Multiplicar = primeiroNumeroArm * segundoNumeroArm;
            Console.WriteLine("Multiplicação: "+Multiplicar);



            if (segundoNumeroArm != 0)
            { 
                double Divisao = primeiroNumeroArm / segundoNumeroArm;
                Console.WriteLine("Divisão: " + Divisao);

                double Resto = primeiroNumeroArm % segundoNumeroArm;
                Console.WriteLine("Resto: " + Resto);

            }else {Console.WriteLine("Não é possível dividir zero!");}
        }
    }
}
