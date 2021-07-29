using System;

namespace SucessorEantecessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, sucessor, antecessor;
            Console.WriteLine("Entre com um número inteiro");
            numero = int.Parse(Console.ReadLine());

            sucessor = numero + 1;
            antecessor = numero - 1;

            Console.WriteLine("O antecessor de " + numero + " é " + antecessor + " e o sucessor é: " + sucessor);
        }
    }
}
