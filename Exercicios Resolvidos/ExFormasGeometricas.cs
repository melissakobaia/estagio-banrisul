using System;

namespace ExFormasGeometricas
{
    class App
    {
        static void Main()
        {
            Console.WriteLine("===Formas Geométricas===\n");

            Retangulo ret = new Retangulo (5, 3);
            Console.WriteLine($"Retângulo: Base {ret.baseRet} | Altura {ret.altura}");
            Console.WriteLine($"Calculo de área: {ret.CalcularArea()} | Calculo de perímetro: {ret.CalcularPerimetro()}\n");

            Quadrado quad = new Quadrado (4);
            Console.WriteLine($"Quadrado: Lado {quad.lado}");
            Console.WriteLine($"Calculo de área: {quad.CalcularArea()} | Calculo de perímetro: {quad.CalcularPerimetro()}\n");

            Circulo circ = new Circulo (2.5);
            Console.WriteLine($"Círculo: Raio {circ.raio}");
            Console.WriteLine($"Calculo de área: {circ.CalcularArea():F2} | Calculo de perímetro: {circ.CalcularPerimetro():F2}\n");
        }
    }

    //Calculos
    abstract class FormaGeometrica
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }

    //Retângulo
    class Retangulo : FormaGeometrica
    {
        public double baseRet;
        public double altura;

        public Retangulo(double b, double a)
        {
            baseRet = b;
            altura = a;
        }

        public override double CalcularArea()
        {
            return baseRet * altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (baseRet + altura);
        }
    }

    //Quadrado
    class Quadrado : FormaGeometrica
    {
        public double lado;

        public Quadrado (double l)
        {
            lado = 1;
        }
        
        public override double CalcularArea()
        {
            return lado * lado;
        }

        public override double CalcularPerimetro()
        {
            return 4 * lado;
        }

    }

    //Círculo
    class Circulo : FormaGeometrica
    {
        public double raio;
            
        public Circulo (double r)
        {
            raio = r;
        }

        public override double CalcularArea()
        {
            return Math.PI * raio * raio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * raio;
        }
    }
}
