using System;

namespace Multiplos1044
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] multiplos;
            int numero1, numero2;
            Console.WriteLine("Entre com dois numeros.");

            multiplos = Console.ReadLine().Split(' ');
            numero1 = int.Parse(multiplos[0]);
            numero2 = int.Parse(multiplos[1]);

            if (numero1 % numero2 == 0 || numero2 % numero1 == 0)
            {
                Console.WriteLine("São múltiplos");
            }
            else
            {
                Console.WriteLine("Não são múltiplos");
            }
        }
    }
}