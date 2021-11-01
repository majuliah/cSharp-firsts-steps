using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop;
            int[] vetor;

            Console.WriteLine("Entre com o tamanho do vetor");
            loop = int.Parse(Console.ReadLine());

            vetor = new int[loop];

            for (int i = 0; i < loop; i++)
            {
                Console.WriteLine($"Entre com o {i + 1} valor");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("O vetor foi: ");
            for (int i = 0; i < loop; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}
