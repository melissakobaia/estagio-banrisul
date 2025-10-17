using System;

namespace exercicio_variaveis_constantes
{
    class App
    {
        static void Main(string[] args)
        {
        const int capacidade_maxima = 1000;
        int ingressos_vendidos = 75;
        int ingressos_restantes = capacidade_maxima - ingressos_vendidos;
        
         Console.WriteLine("Ingressos vendidos:"+ ingressos_vendidos +" de "+ capacidade_maxima);
         Console.WriteLine("Ingressos restantes:"+ ingressos_restantes);
    }
    }
}
