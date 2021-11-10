using static System.Console;
namespace Matriz03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] matrizA;
            int[,] matrizB;
            int[,] matrizC;
            string[] valores;
            int dimensao;
            
            WriteLine("Entre com a dimensão da matriz quadrada: ");
            dimensao = int.Parse(ReadLine());

            matrizA = new int[dimensao, dimensao];
            matrizB = new int[dimensao, dimensao];
            matrizC = new int[dimensao, dimensao];

            WriteLine("Entre com os valores da matriz A");
            for (int a = 0; a < dimensao; a++)
            {
                valores = ReadLine().Split(' ');
                for (int aa = 0; aa < dimensao; aa++)
                    matrizA[a, aa] = int.Parse(valores[aa]);
            }
            WriteLine("Entre com os valores da matriz B");
            for (int b = 0; b < dimensao; b++)
            {
                valores = ReadLine().Split(' ');
                for (int bb = 0; bb < dimensao; bb++)
                    matrizB[b, bb] = int.Parse(valores[bb]);
            }
            WriteLine("A matriz resultante é: ");
            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    matrizC[i, j] = matrizA[i, j] * matrizB[i, j];
                    Write(matrizC[i,j] + " ");
                }
                WriteLine(" ");
            }
            
        }
    }
}