using System;

namespace SequenciaLogica2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o intervalo");
            string[] intervalo = Console.ReadLine().Split(' ');
            int um = int.Parse(intervalo[0]);
            int dois = int.Parse(intervalo[1]);
            
            for (int i = 1; i <= dois; i++)
            {
                Console.WriteLine(i);
                if (i % um == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
}