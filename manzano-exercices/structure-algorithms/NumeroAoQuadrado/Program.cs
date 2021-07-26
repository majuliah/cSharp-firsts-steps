using System;

namespace NumeroAoQuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, numeroQuadrado;
            Console.WriteLine("Entre com um número");
            numero = int.Parse(Console.ReadLine());

            numeroQuadrado = (int)Math.Pow(numero, 2);

            Console.WriteLine("O número " + numero + " ao quadrado é: " + numeroQuadrado);

        }
    }
}
