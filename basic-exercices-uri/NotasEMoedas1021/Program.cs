using System;
using System.Globalization;

namespace NotasEMoedas1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            int notas, moedas, resto, resultado;
            
            Console.WriteLine("Entre com o valor em dinheiro");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resto = (int) (valor * 100 + 0.5);
                //estamos multiplicando o valor por 100 para forçar que ele fique inteiro
                //somando o 0.5 para que o resultado após o cálculo com double fique preciso
             
            //como multiplicamos o valor por 100, também devemos multiplicar os valores das notas por 100

            notas = 100;
            resultado = resto / (notas * 100);
            resto = resto % (notas * 100);
            Console.WriteLine($"{resultado} notas de R$100,00");

            notas = 50;
            resultado = resto / (notas * 100);
            resto = resto % (notas * 50);
            Console.WriteLine($"{resultado} notas de R$50,00");

            notas = 20;
            resultado = resto / (notas * 20);
            resto = resto % (notas * 20);
            Console.WriteLine($"{resultado} notas de R$20,00");

            notas = 10;
            resultado = resto / (notas * 20);
            resto = resto % (notas * 10);
            Console.WriteLine($"{resultado} notas de R$10,00");

            notas = 5;
            resultado = resto / (notas * 5);
            resto = resto % (notas * 5);
            Console.WriteLine($"{resultado} notas de R$5,00");

            notas = 2;
            resultado = resto / (notas * 2);
            resto = resto % (notas * 2);
            Console.WriteLine($"{resultado} notas de R$2,00");
            
            //agora as moedas tem de ser expressadas em valores inteiros

            moedas = 100;
            resultado = resto / moedas;
            Console.WriteLine($"{resultado} moedas de R$1,00");

            moedas = 50;
            resultado = resto / moedas;
            Console.WriteLine($"{resultado} moedas de R$0.50");

            moedas = 25;
            resultado = resto / moedas;
            Console.WriteLine($"{resultado} moedas de R$0.25");

            moedas = 10;
            resultado = resto / moedas;
            Console.WriteLine($"{resultado} moedas de R$0.10");

            moedas = 5;
            resultado = resto / moedas;
            Console.WriteLine($"{resultado} moedas de R$0.5");

            moedas = 1;
            resultado = resto / moedas;
            Console.WriteLine($"{resultado} moedas de R$0.1");
            
        }
    }
}
