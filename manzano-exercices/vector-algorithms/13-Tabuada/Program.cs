using System;
using static System.Console;

namespace _13_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabuada = new int[10];
            int valor;
            
            WriteLine("Entre com o número da tabuada");
            valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
                tabuada[i] = (i + 1) * valor;
            
            foreach (var resultado in tabuada)
                Write(resultado + " ");
        }
    }
}
