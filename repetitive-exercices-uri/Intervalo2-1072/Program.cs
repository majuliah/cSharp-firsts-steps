using System;

namespace Intervalo2_1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, x, valIn = 0, valOut = 0, cont = 0;
            Console.WriteLine("Entre com um valor inteiro.");
            valor = int.Parse(Console.ReadLine());

            while (cont < valor)
            {
                Console.WriteLine($"Entre com o {cont + 1}º número.");
                x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    valIn += 1;
                }
                else
                {
                    valOut += 1;
                }
                cont += 1;
            }
            Console.WriteLine($"{valIn} in \n {valOut} out");
            
        }
    }
}