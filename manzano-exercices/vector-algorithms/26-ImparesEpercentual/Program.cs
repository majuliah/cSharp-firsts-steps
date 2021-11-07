using System;
using System.Globalization;
using static System.Console;

namespace _26_ImparesEpercentual
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[5];
            string[] vet;
            int totImpar = 0;
            double porcentagem;

            for (int i = 0; i < 5; i++)
            {
                do
                {
                    WriteLine("Entre com valores maior que 0");
                    vetorA[i] = int.Parse(ReadLine());
                } while (vetorA[i] < 0);

                if (vetorA[i] % 2 != 0)
                    totImpar++;
            }

            porcentagem = (totImpar / 5.0) * 100.0;
            
            WriteLine($"O total de números ímpar é: {totImpar} e a porcentagem de números ímpar no vetor é {porcentagem.ToString("F1", CultureInfo.InvariantCulture)}%");
            
        }
    }
}
