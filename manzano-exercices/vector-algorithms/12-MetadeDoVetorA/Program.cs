using System.Globalization;
using static System.Console;

namespace _12_MetadeDoVetorA
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor;
            int[] vetorA = new int[5];
            double[] vetorB = new double[5];
            
            WriteLine("Entre com os valores para o vetor A");
            vetor = ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
            {
                vetorA[i] = int.Parse(vetor[i]);
                vetorB[i] = (double) vetorA[i] / 2.0;
            }
            foreach (var number in vetorB)
                Write(number.ToString("F1", CultureInfo.InvariantCulture) + " ");
            
        }
    }
}
