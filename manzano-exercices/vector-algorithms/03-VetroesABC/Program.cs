using System;
using static System.Console;

namespace _03_VetroesABC
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetores;
            int[] vetorA, vetorB, vetorC;
            vetorA = new int[5];
            vetorB = new int[5];
            vetorC = new int[5];
            
            WriteLine("Entre com os valores para o vetor A");
            vetores = ReadLine().Split(' ');
            for (int i = 0; i < 5; i++)
                vetorA[i] = int.Parse(vetores[i]);

            WriteLine("Agora entre com os valores para o vetor B");
            vetores = ReadLine().Split(' ');
            for (int i = 0; i < 5; i++)
                vetorB[i] = int.Parse(vetores[i]);
            
            for (int i = 0; i < 5; i++)
                vetorC[i] = vetorA[i] - vetorB[i];

            for (int i = 0; i < 5; i++)
                Write(vetorC[i] + " ");
            
                
                
            
        }
    }
}
