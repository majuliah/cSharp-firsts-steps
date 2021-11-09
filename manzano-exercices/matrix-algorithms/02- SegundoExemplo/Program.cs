using static System.Console;

namespace _02__SegundoExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[3,3];
            int[,] matrizB = new int[3,3];
            int[,] matrizC = new int[3,3];
            string[] valores;
            
            WriteLine("Entre com os valores da matriz 3x3");

            for (int i = 0; i < 3; i++)
            {
                valores = ReadLine().Split(' ');
                for (int j = 0; j < 3; j++)
                {
                    matrizA[i, j] = int.Parse(valores[j]);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                valores = ReadLine().Split(' ');
                for (int j = 0; j < 3; j++)
                {
                    matrizB[i, j] = int.Parse(valores[j]);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Write(matrizC[i,j] + ' ');
            }
            
        }
    }
}
