using static System.Console;

namespace _19_SomenteParEsomenteImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[5];
            int[] vetorB = new int[5];
            int[] vetorC = new int[10];
            int cont = 5;

            WriteLine("Entre com os valores pares do vetor A");
            for (int i = 0; i < 5; i++)
            {
                vetorA[i] = int.Parse(ReadLine());
                while (vetorA[i] % 2 != 0)
                {
                    WriteLine("Somente valores pares permitidos.");
                    vetorA[i] = int.Parse(ReadLine());
                }
                vetorC[i] = vetorA[i];
            }
            
            WriteLine("Agora entre com os valores pares do vetor B");
            for (int i = 0; i < 5; i++)
            {
                vetorB[i] = int.Parse(ReadLine());
                while (vetorB[i] % 2 == 0)
                {
                    WriteLine("Somente valores ímpares permitidos.");
                    vetorB[i] = int.Parse(ReadLine());
                }
                vetorC[cont] = vetorB[i];
                cont++;
            }
            
            foreach (var number in vetorC)
                Write(number + " ");
        }
    }
}
