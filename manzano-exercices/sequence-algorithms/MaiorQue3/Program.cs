using System;

namespace MaiorQue3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Entre com um número");
            numero = int.Parse(Console.ReadLine());

            if (!(numero > 3))
            {
                Console.WriteLine(numero);
            }
            else
            {
                Console.WriteLine("Número maior que 3");
            }
        }
    }
}