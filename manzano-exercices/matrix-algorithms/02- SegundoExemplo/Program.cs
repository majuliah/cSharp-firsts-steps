using static System.Console;

namespace _02__SegundoExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] leitura;
            int[,] matrizA;
            int[,] matrizB;
            int[,] matrizC;
            int numero;
            
            WriteLine("Entre com a quantidade de linhas e colunas: ");
            numero = int.Parse(ReadLine());

            matrizA = new int[numero, numero];
            matrizB = new int[numero, numero];
            matrizC = new int[numero, numero];

            WriteLine("Entre com a primeira matriz: ");

            for (int i = 0; i < numero; i++)
            {
                leitura = ReadLine().Split(' ');
                for (int j = 0; j < numero; j++)
                    matrizA[i, j] = int.Parse(leitura[j]);
            }
            
            WriteLine("Entre com a segunda matriz: ");

            for (int i = 0; i < numero; i++)
            {
                leitura = ReadLine().Split(' ');

                for (int j = 0; j < numero; j++)
                    matrizB[i, j] = int.Parse(leitura[j]);
            }

            WriteLine("A matriz resultante é: ");
            
            for (int i = 0; i < numero; i++)
            {
                for (int j = 0; j < numero; j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                    Write(matrizC[i,j] + " ");
                }
                WriteLine(" ");
            }
        }
    }
}
