using static System.Console;

namespace _22_TotalParEimpar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores;
            int[] vetorA = new int[10];
            int totPar = 0, totImpar = 0;
            
            WriteLine("Entre com os valores do vetor:");
            valores = ReadLine().Split(' ');

            for (int i = 0; i < 10 ; i++)
            {
                vetorA[i] = int.Parse(valores[i]);

                if (vetorA[i] % 2 == 0)
                    totPar++;
                else
                    totImpar++;
            }
            
            WriteLine($"O total de números ímpares é {totImpar} e o de pares é {totPar}");
            
        }
    }
}
