using System;

namespace NumeroPerfeito1164
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada, numero, soma = 0;
            Console.WriteLine("Entre com a quantidade de verificações:");
            entrada = int.Parse(Console.ReadLine());

            for (int i = 1; i <= entrada; i++)
            {
                Console.WriteLine("Número:");
                numero = int.Parse(Console.ReadLine());
                for (int j = 1; j < numero; j++)
                {
                    if (numero % j == 0)
                    {
                        soma += j;
                    }
                }
                if (soma == numero)
                {
                    Console.WriteLine($"{numero} eh perfeito");
                }
                else
                {
                    Console.WriteLine($"{numero} não eh perfeito");
                }
            }
        }
    }
}