using System;

namespace QuadradoDaDiferenca
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, resultado;
            Console.WriteLine("Entre com dois valores inteiros");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            resultado = (int)Math.Pow(A - B, 2);

            Console.WriteLine("A diferença do primeiro valor pelo segundo elevado ao quadrado é: " + resultado);

        }
    }
}
