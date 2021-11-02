using System;
using System.Globalization;
using static System.Console;

namespace Vetores02
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            string[] valores;
            double[] vetor;
            double soma = 0.0, media = 0.0;
            
            WriteLine("Entre com a quantidade de posições para o vetor:");
            index = int.Parse(ReadLine());
            vetor = new double[index];
            
            WriteLine("Entre com os elementos do vetor");
            valores = ReadLine().Split(' ');


            for (int i = 0; i < index; i++)
            {
                vetor[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
                soma += vetor[i];
            }

            media = soma / (double)index;
            
            WriteLine("Os elementos do vetor são: ");
            
            for (int i = 0; i < index; i++)
                Write(vetor[i] + " ");
            
            WriteLine();
            WriteLine($"A soma é {soma.ToString("F1", CultureInfo.InvariantCulture)} e a média é {media.ToString("F1", CultureInfo.InvariantCulture)}");
            
        }
    }
}


