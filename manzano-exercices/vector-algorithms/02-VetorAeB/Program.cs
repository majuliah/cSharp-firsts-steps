using static System.Console;

namespace _02_VetorAeB
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA, vetorB;
            vetorA = new int[8];
            vetorB = new int[8];
            
            WriteLine("Entre com oito números");
             for (int i = 0; i < 8; i++)
            {
                vetorA[i] = int.Parse(ReadLine());
                vetorB[i] = vetorA[i] * 3;
            }

            WriteLine("O vetor é: ");

            foreach (var number in vetorB)
            {
                Write(number + " ");
            }
             
        }
    }
}
