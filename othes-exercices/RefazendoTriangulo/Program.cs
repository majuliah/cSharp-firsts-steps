using System;

namespace RefazendoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1, lado2, lado3, somaLado1e2, somaLado1e3, somaLado2e3;
            Console.WriteLine("Entre com três lados de um triangulo");
            string[] lados = Console.ReadLine().Split(' ');
            lado1 = int.Parse(lados[0]);
            lado2 = int.Parse(lados[1]);
            lado3 = int.Parse(lados[2]);

            somaLado1e2 = lado1 + lado2;
            somaLado1e3 = lado1 + lado3;
            somaLado2e3 = lado2 + lado3;

            if ((lado1 < somaLado2e3) & (lado2 < somaLado1e3) & (lado3 < somaLado1e2))
            {
                if ((lado1 == lado2) & (lado1 == lado3))
                {
                    Console.WriteLine("Triangulo EQUILÁTERO");

                } else if ((lado1 == lado2) || (lado2 == lado3) || (lado1 == lado3)) 
                {
                    Console.WriteLine("Triângulo Isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo Escaleno!");
                }
            } else
            {
                Console.WriteLine("Não é possível Formar um triângulo");
            }

        }
    }
}
