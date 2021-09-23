using System;

namespace SomaParesConsecutivos1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma, x;
            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                if (x % 2 == 0)
                {
                    soma = x + (x + 2) + (x + 4) + (x + 6) + (x + 8);
                    Console.WriteLine($"A soma é {soma}");
                }
                else
                {
                    soma = x + 1 + (x + 3) + (x + 5) + (x + 7) + (x + 9);
                    Console.WriteLine($"A soma é {soma}");
                }

                Console.WriteLine("Continuar?");
                x = int.Parse(Console.ReadLine());
                
            }

        }
    }
}

