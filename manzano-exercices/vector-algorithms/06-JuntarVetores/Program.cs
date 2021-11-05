using static System.Console;

namespace _06_JuntarVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[5];
            int[] vetorB = new int[5];
            int[] vetorC = new int[10];
            string[] vetor;
            int j = 5;
            
            WriteLine("Entre com os tamanhos dos vetores");
            vetor = ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
            {
                vetorA[i] = int.Parse(vetor[i]);
                vetorC[i] = vetorA[i];
            }
            
            WriteLine("Agora entre com os valores para o vetor B");
            vetor = ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
            {
                vetorB[i] = int.Parse(vetor[i]);
                vetorC[j] = vetorB[i];
                j++;
            }

            foreach (var number in vetorC)
                Write(number + " ");
            
            
        }
    }
}
