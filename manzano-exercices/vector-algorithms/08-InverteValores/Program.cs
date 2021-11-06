using static System.Console;

namespace _08_InverteValores
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Inverte vetor A = vetor B");
            int[] vetorA = new int[5];
            int[] vetorB = new int[5];
            string[] vetor;
            int cont = 0;
            
            WriteLine("Entre com os valores do vetor A");
            vetor = ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
                vetorA[i] = int.Parse(vetor[i]);

            for (int i = 4; i >= 0; i--)
            {
                vetorB[cont] = vetorA[i];
                cont++;
            }

            WriteLine("Vetor A ao contrário é: ");
            
            foreach (var number in vetorB)
                Write(number + " ");
            
            

        }
    }
}
