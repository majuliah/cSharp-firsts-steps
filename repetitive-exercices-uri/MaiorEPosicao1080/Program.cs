using System;

namespace MaiorEPosicao1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, maior = 0, posicao = 0;
            Console.WriteLine("Entre com 100 valores");

            for (int i = 0; i < 100; i++)
            {
                numero = int.Parse(Console.ReadLine());
                if (numero > maior)
                {
                    maior = numero;
                    posicao = i;
                }
            }
            Console.WriteLine($"O maior número foi {maior} na posição {posicao + 1}");
        }
    }
}