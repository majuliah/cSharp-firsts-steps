using System;

namespace SomaEProdutoEntreValores
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores;
            int valor1, valor2, valor3, valor4, resultado;
            Console.WriteLine("Entre com quatro valores inteiros");
            valores = Console.ReadLine().Split(' ');
            valor1 = int.Parse(valores[0]);
            valor2 = int.Parse(valores[1]);
            valor3 = int.Parse(valores[2]);
            valor4 = int.Parse(valores[3]);

            resultado = (valor1 * valor3) + (valor2 + valor4);

            Console.WriteLine("O resultado do produto do primeiro com o terceiro valor mais o segundo mais o quarto é (valor1 * valor3) + (valor2 + valor4): " + resultado);
        }
    }
}
