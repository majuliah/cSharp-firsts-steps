using System;

namespace QuadradoDaSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3, resultado;
            Console.WriteLine("Entre com três valores!");
            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());
            valor3 = int.Parse(Console.ReadLine());

            resultado = (int)Math.Pow(valor1, 2) + (int)Math.Pow(valor2, 2) + (int)Math.Pow(valor3, 2);

            Console.WriteLine("Resultado: " + resultado);


        }
    }
}
