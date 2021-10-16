using System;

namespace SomandoInteirosEConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroA, numeroN, i = 1, soma = 0;
            Console.WriteLine("Entre com dois valores");
            string[] valores = Console.ReadLine().Split(' ');

            numeroA = int.Parse(valores[0]);
            numeroN = int.Parse(valores[i]);
            while (numeroN <= 0)
            {
                i += 1;
                numeroN = int.Parse(valores[1]);
            }

            for (int j = 0; j < numeroN; j++)
            {
                soma += numeroA + i;
            }
            Console.WriteLine(soma);
        }
    }
}