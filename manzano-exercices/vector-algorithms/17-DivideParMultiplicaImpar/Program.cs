using System.Globalization;
using static System.Console;

namespace _17_DivideParMultiplicaImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[5];
            double[] vetorB = new double[5];
            string[] valores;
            
            WriteLine("Entre com o vetor A");
            valores = ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
            {
                vetorA[i] = int.Parse(valores[i]);

                if (vetorA[i] % 2 == 0)
                    vetorB[i] = (vetorA[i] / 2.0);
                else
                    vetorB[i] = (vetorA[i] * 1.5);
            }
            foreach (var result in vetorB)
                Write(result.ToString("F1", CultureInfo.InvariantCulture) + " ");
        }
    }
}
