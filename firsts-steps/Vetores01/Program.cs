using System;
using static System.Console;

namespace Vetores01
{
    class Program
    {
        static void Main(string[] args)
        {
            int indice;
            int[] vetor;
            string[] entrada;
            
            WriteLine("Entre com a quantidade de posições do vetor: ");
            indice = int.Parse(ReadLine());
            vetor = new int[indice];
            
            WriteLine($"Entre co os {indice} números do vetor");
            entrada = ReadLine().Split(' ');
            
            for (int i = 0; i < indice; i++)
                vetor[i] = int.Parse(entrada[i]);
            
            WriteLine("Os números negativos lidos foram: ");
            for (int i = 0; i < indice; i++)
            {
                if (vetor[i] < 0)
                    WriteLine(vetor[i]);
            }

        }
    }
}
