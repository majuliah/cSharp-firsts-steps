using System;

namespace Teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, soma;

            while (x < 10)
            {
                Console.WriteLine($"X é: {x} e Y é: {y}");
                y = y + 2;
                x = x + 1;
            }

            soma = x + y;
            Console.WriteLine($"soma de x e y é {soma}, x vale {x} e y vale {y}");
        }
    }
}