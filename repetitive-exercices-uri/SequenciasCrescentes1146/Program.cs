using System;

namespace SequenciasCrescentes1146
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            while (numero > 0)
            {
                string sequence = "";
                for (int i = 1; i < numero; i++)
                {
                    sequence +=  i + " ";
                }
                sequence += numero;
                Console.WriteLine(sequence);
                numero = int.Parse(Console.ReadLine());
            }
        }
    }
}