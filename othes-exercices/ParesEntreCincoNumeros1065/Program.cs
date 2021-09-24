using System;

namespace ParesEntreCincoNumeros1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros, pares = 0;

            Console.WriteLine("ENtre com 5 valores");
            for (int i = 0; i <= 4; i++)
            {
                numeros = int.Parse(Console.ReadLine());
                if (numeros % 2 == 0)
                {
                    pares += 1;
                }
            }

            Console.WriteLine($"{pares} valores pares");
        }
    }
}