using System;
using Microsoft.VisualBasic;

namespace SequenciaDeNumerosESoma1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, min, max, soma = 0;
            string[] numeros;

            Console.WriteLine("Entre com dois números");
            numeros = Console.ReadLine().Split(' ');
            numero1 = int.Parse(numeros[0]);
            numero2 = int.Parse(numeros[1]);



            while (numero1 > 0 && numero2 > 0)
            {
                if (numero1 > numero2)
                {
                    max = numero1;
                    min = numero2;
                }
                else
                {
                    min = numero1;
                    max = numero2;
                }

                if (numero1 > 0 && numero2 > 0)
                {
                    for (int i = min; i <= max; i++)
                    {
                        soma += i;
                        Console.Write($"{i} ");
                    }
                    Console.WriteLine($" Sum={soma}");
                }

                Console.WriteLine("Continuar (0 - sai)");
                numeros = Console.ReadLine().Split(' ');
                numero1 = int.Parse(numeros[0]);
                numero2 = int.Parse(numeros[1]);
            }
        }
    }
}