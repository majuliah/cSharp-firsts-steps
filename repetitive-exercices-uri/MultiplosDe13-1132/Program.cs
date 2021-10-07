using System;

namespace MultiplosDe13_1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, maior, menor, soma = 0;
            Console.WriteLine("Entre com dois números");

            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                maior = numero1;
                menor = numero2;
            }
            else
            {
                menor = numero1;
                maior = numero2;
            }
            

            for (int i = menor; i <= maior; i++)
            {
                if (i % 13 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine($"A soma é {soma}");

        }
    }
}