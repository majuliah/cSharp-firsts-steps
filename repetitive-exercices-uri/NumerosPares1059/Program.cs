using System;

namespace NumerosPares1059
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            while (numero < 100)
            {
                numero += +2;
                Console.WriteLine(numero);
            }
        }
    }
}