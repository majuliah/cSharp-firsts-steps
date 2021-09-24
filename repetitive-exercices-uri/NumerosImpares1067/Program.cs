using System;

namespace NumerosImpares1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                for (int i = 1; i < numero; i+=2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = 1; i <= numero; i+=2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}