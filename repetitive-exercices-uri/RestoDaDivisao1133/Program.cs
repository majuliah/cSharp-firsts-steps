using System;

namespace RestoDaDivisao1133
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, maximo, minimo;
            Console.WriteLine("Entre com dois valores.");

            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                maximo = numero1;
                minimo = numero2;
            }
            else
            {
                maximo = numero2;
                minimo = numero1;
            }

            Console.WriteLine("Os resultados são:");

            for (double i = minimo; i < maximo; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}