using static System.Console;

namespace _01_Primeiro_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[2, 3];
            string[] linha;
            
            for (int i = 0; i < 2; i++)
            {
                linha = ReadLine().Split(' ');
                for (int j = 0; j < 3; j++)
                {
                    matrizA[i, j] = int.Parse(linha[j]);
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Write(matrizA[i, j] + " ");
                }
                WriteLine(" ");
            }
            
        }
    }
}
