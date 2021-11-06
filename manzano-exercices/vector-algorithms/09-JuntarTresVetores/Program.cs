using static System.Console;

namespace _09_JuntarTresVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[5];
            int[] vetorB = new int[5];
            int[] vetorC = new int[5];
            int[] vetorD = new int[15];
            string[] vetores;
            int cont1 = 5, cont2 = 10;
            
            WriteLine("Entre com os valores do vetor A: ");
            vetores = ReadLine().Split(' ');
            for (int i = 0; i < 5; i++)
            {
                vetorA[i] = int.Parse(vetores[i]);
                vetorD[i] = vetorA[i];
            }
            
            WriteLine("Agora entre com os valores do vetor B");
            vetores = ReadLine().Split(' ');
            for (int i = 0; i < 5; i++)
            {
                vetorB[i] = int.Parse(vetores[i]);
                vetorD[cont1] = vetorB[i];
                cont1++;
            }

            WriteLine("Por fim, os valores do vetor C");
            vetores = ReadLine().Split(' ');
            for (int i = 0; i < 5; i++)
            {
                vetorC[i] = int.Parse(vetores[i]);
                vetorD[cont2] = vetorC[i];
                cont2++;
            }

            foreach (var number in vetorD)
            {
                Write(number + " ");
            }
        }
    }
}
