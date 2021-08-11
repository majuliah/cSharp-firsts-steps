using System;

namespace AnoBissexto
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            Console.WriteLine("Entre com um ano!");
            ano = int.Parse(Console.ReadLine());

            if(ano % 4 == 0)
            {
                Console.WriteLine("É bissexto!");
            }
            else
            {
                Console.WriteLine("Não é bissexto");
            }
        }
    }
}
