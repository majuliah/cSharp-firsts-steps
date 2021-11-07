using static System.Console;

namespace _16_ImparMultiplicaPor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[5];
            int[] vetorB = new int[5];
            string[] valores;
            
            WriteLine("Entre com os valores para compor o vetor");
            valores = ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
            {
                vetorA[i] = int.Parse(valores[i]);

                if (vetorA[i] % 2 != 0)
                    vetorB[i] = vetorA[i] * 2;
                else
                    vetorB[i] = vetorA[i];
            }

            foreach (var result in vetorB)
                Write(result + " ");
        }
    }
}
