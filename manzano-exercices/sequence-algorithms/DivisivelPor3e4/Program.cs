using System;

namespace DivisivelPor3e4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores;
            int valorA, valorB, valorC, valorD;
            Console.WriteLine("Hello World!");
            valores = Console.ReadLine().Split(' ');
            valorA = int.Parse(valores[0]);
            valorB = int.Parse(valores[1]);
            valorC = int.Parse(valores[2]);
            valorD = int.Parse(valores[3]);

            if (valorA % 2 == 0 || valorA % 3 == 0)
            {
                Console.WriteLine(valorA);

                if (valorB % 2 == 0 || valorB % 3 == 0)
                {
                    Console.WriteLine(valorB);
                }

                if (valorC % 2 == 0 || valorC % 3 == 0)
                {
                    Console.WriteLine(valorC);
                }

                if (valorD % 2 == 0 || valorD % 3 == 0)
                {
                    Console.WriteLine(valorD);
                }
            }
            else
            {
                Console.WriteLine("Nenhum valor é divisível por 2 ou 3");
            }
        }
    }
}