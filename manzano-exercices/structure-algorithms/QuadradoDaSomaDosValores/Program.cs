using System;

namespace QuadradoDaSomaDosValores
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3, resultado;
            string[] valores;
            Console.WriteLine("Entre com três valores");
            valores = Console.ReadLine().Split(' ');
            numero1 = int.Parse(valores[0]);
            numero2 = int.Parse(valores[1]);
            numero3 = int.Parse(valores[2]);

            resultado = (int)Math.Pow(numero1 + numero2 + numero3, 2);

            Console.WriteLine("O resultado do quadrado da soma dos números lidos é: " + resultado);
        }
    }
}
