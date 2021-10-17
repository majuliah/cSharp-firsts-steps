using System;

namespace PUM1142
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um valor inteiro");
            int valor = int.Parse(Console.ReadLine());

            int inicio = 1;

            for (int i = 1; i <= valor; i++)
            {
                int segundo = inicio + 1;
                int terceiro = inicio + 2;
                Console.WriteLine($"{inicio} {segundo} {terceiro} PUM");

                inicio += 4;

            }
        }
    }
}