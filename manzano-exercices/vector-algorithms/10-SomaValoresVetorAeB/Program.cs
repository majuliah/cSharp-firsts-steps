using static System.Console;

namespace _10_SomaValoresVetorAeB
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[5];
            int[] vetorB = new int[5];
            string[] vetor;
            int cont = 0;
            
            WriteLine("Entre com os valores do vetor A");
            vetor = ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
            {
                vetorA[i] = int.Parse(vetor[i]);

                for (int j = vetorA[i]; j >= 1; j--)
                    cont += j;
                
                vetorB[i] = cont;
                cont = 0;
            }
            
            WriteLine("Vetor B é: ");
            foreach (var number in vetorB)
            {
                Write(number + " ");
            }
        }
    }
}
