using System;

namespace SomaDeImparesCosecutivos1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, soma, min, max;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                min = y;
                max = x;
            }
            else
            {
                min = x;
                max = y;
            }

            soma = 0;

            for (int i = min + 1; i < max ; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine($"{soma}");

        }
    }
}