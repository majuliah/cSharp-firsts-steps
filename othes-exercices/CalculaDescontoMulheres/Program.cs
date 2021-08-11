using System;
using System.Globalization;

namespace CalculaDescontoMulheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome, sexo e o valor da sua compra");
            string nome = Console.ReadLine();
            char sexo = char.Parse(Console.ReadLine());
            double valorCompra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto, valorTotal;

            if(sexo == 'F')
            {
                desconto = (valorCompra * 0.13);
                valorTotal = valorCompra - desconto;
                Console.WriteLine(nome + " seu desconto foi de:" + desconto.ToString("F2", CultureInfo.InvariantCulture) + " e o valor da compra é: R$" + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            } else if (sexo == 'M')
            {
                desconto = (valorCompra * 0.05);
                valorTotal = valorCompra - desconto;
                Console.WriteLine(nome + " seu desconto foi de:" + desconto.ToString("F2", CultureInfo.InvariantCulture) + " e o valor da compra é: R$" + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            
        }
    }
}
