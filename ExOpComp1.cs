using System;


namespace ExOpComp1
{
    class App
    {
        static void Main(string[] args)
        {   
            //Entrada
            Console.Write("Digite dois números: ");

            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            //Operações
            Console.WriteLine($"{num1} > {num2} → {num1 > num2}");
            Console.WriteLine($"{num1} < {num2} → {num1 < num2}");
            Console.WriteLine($"{num1} == {num2} → {num1 == num2}");
            Console.WriteLine($"{num1} != {num2} → {num1 != num2}");
            Console.WriteLine($"{num1} >= {num2} → {num1 >= num2}");
            Console.WriteLine($"{num1} <= {num2} → {num1 <= num2}");
        }
    }
}
