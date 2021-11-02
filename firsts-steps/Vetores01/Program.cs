using System;

namespace Vetores01
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 10, flag = 0, i = 0;
            double media, soma = 0, numero;
            double[] info;
            info = new double[max];

            Console.WriteLine("Entre com os valores numéricos");
            numero = double.Parse(Console.ReadLine());

            while (numero != flag)
            {
                i += 1;
                info[i] = numero;
                numero = double.Parse(Console.ReadLine());
            }
            numero = i;

            if (numero == max && numero != flag)
            {
                Console.WriteLine($"O valor {numero} não foi armazenado porque o vetor está cheio!");
            }

            if (numero > 0)
            {
                for (int j = 0; j < numero; j++)
                {
                    soma += info[i];
                }
                
                media = soma / numero;

                for (int j = 0; j < numero; j++)
                {
                    Console.WriteLine($"Os valores lidos foram: {info[i]}");
                }

                Console.WriteLine($"A média aritmética é: {media}");
            }
            else
            {
                Console.WriteLine("Não há valores para cálculo de média.");
            }
        }
    }
}
