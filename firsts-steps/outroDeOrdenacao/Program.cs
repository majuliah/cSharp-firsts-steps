using static System.Console;
namespace outroDeOrdenacao
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int auxiliar, soma = 0;
            string[] entrada;
            
            WriteLine("Entre com os valores do vetor: ");
            entrada = ReadLine().Split(' ');

            for (int i = 0; i < 10; i++)
            {
                vetor[i] = int.Parse(entrada[i]);
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (vetor[i] < vetor[j])
                    {
                        auxiliar = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = auxiliar;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                soma += vetor[i];
                Write(vetor[i] + " ");
            }
            WriteLine(" ");
            WriteLine($"A soma do vetor foi: {soma}");
        }
    }
}