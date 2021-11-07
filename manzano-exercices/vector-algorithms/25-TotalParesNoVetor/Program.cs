using static System.Console;

namespace _25_TotalParesNoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[5];
            string[] vetor;
            int totPar = 0;
            
            WriteLine("Entre com os valores do vetor A:");
            vetor = ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
            {
                valores[i] = int.Parse(vetor[i]);
                if (valores[i] % 2 == 0)
                    totPar++;
            }
            
            Write($"Existem {totPar} valores par no vetor A.");
            
        }
    }
}
