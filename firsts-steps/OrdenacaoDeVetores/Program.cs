using static System.Console;

namespace OrdenacaoDeVetores
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char[] vetorLetras = new char[10];
            string[] letras;
            char entradas;
            
            WriteLine("Entre com 10 letras para efetuarmos a ordenação");
            letras = ReadLine().Split(' ');

            for (int i = 0; i < 10; i++)
                vetorLetras[i] = char.Parse(letras[i]);
            
            
            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (vetorLetras[i] > vetorLetras[j])
                    {
                        entradas = vetorLetras[i];
                        vetorLetras[i] = vetorLetras[j];
                        vetorLetras[j] = entradas;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
                Write(vetorLetras[i] + " ");
        }
    }
}