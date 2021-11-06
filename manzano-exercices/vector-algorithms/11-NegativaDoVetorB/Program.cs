using static System.Console;

namespace _11_NegativaDoVetorB
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor;
            int[] vetorA = new int[5];
            int[] vetorB = new int[5];
            
            WriteLine("Entre com os valores do vetor A");
            vetor = ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
            {
                vetorA[i] = int.Parse(vetor[i]);

                if (vetorA[i] > 0)
                    vetorB[i] = vetorA[i] * (-1);
                else
                    vetorB[i] = vetorA[i];
            }

            foreach (var number in vetorB)
                Write(number + " ");
        }
    }
}
