using System;

namespace SequenciaLogica1144
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um valor inteiro");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
                Console.WriteLine($"{primeiro} {segundo + 1} {terceiro + 1}");
            }
        }
    }
}