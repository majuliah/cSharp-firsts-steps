using System;

namespace FibonacciFacil1151
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o número de sequências: ");
            int numero = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            for (int i = 0; i < numero; i++)
            {
                if (i == numero - 1)
                    Console.WriteLine(a);
                else
                    Console.Write(a + " ");

                int aux = b;
                b = a;
                a = aux + b;
            }
        }
    }
}