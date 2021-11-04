using System;
using System.Globalization;
using static System.Console;

namespace _04_QuadradoDaRaizA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[5];
            int[] vetorB = new int[5];
            string[] vetores;
            
            WriteLine("Entre com os valores do vetor A: ");
            vetores = ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
            {
                vetorA[i] = int.Parse(vetores[i]);
                vetorB[i] = (int) Math.Pow(vetorA[i], 2);
            }

            foreach (var number in vetorA)
                Write(number + " ");

            WriteLine(" ");
            
            foreach (var result in vetorB)
                Write(result + " ");



        }
    }
}
