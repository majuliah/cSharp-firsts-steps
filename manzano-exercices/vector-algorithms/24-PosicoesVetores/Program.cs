using static System.Console;

namespace _24_PosicoesVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor;
            int[] vetorA = new int[5];
            int[] vetorB = new int[5];
            int impar = 1;
            int par = 0;
            
            WriteLine("Entre com os valores do vetor A:");
            vetor = ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
            {
                vetorA[i] = int.Parse(vetor[i]);
                if (i % 2 == 0)
                {
                    vetorB[impar] = vetorA[i];
                    impar += 2;
                }
                else
                {
                    vetorB[par] = vetorA[i];
                    par += 2;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Write($"Posição {i} é {vetorA[i]}, ");
            }
            
            WriteLine(" --- ");
            
            for (int i = 0; i < 5; i++)
            {
                Write($"Posição {i} é {vetorB[i]}, ");
            }
            
        }
    }
}
