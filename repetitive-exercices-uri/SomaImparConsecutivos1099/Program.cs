using System;

namespace SomaImparConsecutivos1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int testes, numero1, numero2, min, max, soma = 0;
            string[] entrada;
            Console.WriteLine("Entre com a quantidade de testes a serem realizados:");
            testes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= testes; i++)
            {
                Console.WriteLine("Entre com dois números");
                entrada = Console.ReadLine().Split(' ');
                numero1 = int.Parse(entrada[0]);
                numero2 = int.Parse(entrada[1]);

                if (numero1 > numero2)
                {
                    max = numero1;
                    min = numero2;
                }
                else
                {
                    max = numero2;
                    min = numero1;
                }

                for (int j = min; j <= max; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                    }
                }
                
                Console.WriteLine($"Soma = {soma}");
                soma = 0;

            }
        }
    }
}