using System;

namespace Divisores1_1157
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Entre com um número");
            numero = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}