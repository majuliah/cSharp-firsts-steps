using static System.Console;

namespace _05_FatorialDOVetorA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[5];
            int[] vetorB = new int[5];
            string[] vetores;
            int potencia = 1;

            WriteLine("Entre com os valores para compor o vetor");
            vetores = ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
            {
                vetorA[i] = int.Parse(vetores[i]);

                for (int j = vetorA[i]; j > 1; j--)
                {
                    potencia *= j;
                }

                vetorB[i] = potencia;
                potencia = 1;
            }


            foreach (var number in vetorB)
            {
                WriteLine(number);
            }
            

            
                

        }
    }
}
