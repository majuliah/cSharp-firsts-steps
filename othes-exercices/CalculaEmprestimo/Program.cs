using System;
using System.Globalization;

namespace CalculaEmprestimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano, anos;
            double salario, valorCasa, prestacao, porcentagem;
            Console.WriteLine("Entre com o valor da casa, o seu salário e em quantos anos vai pagar a casa");
            string[] informacoes = Console.ReadLine().Split(' ');
            valorCasa = double.Parse(informacoes[0], CultureInfo.InvariantCulture);
            salario = double.Parse(informacoes[1], CultureInfo.InvariantCulture);
            ano = int.Parse(informacoes[2]);
            anos = ano * 12;
            prestacao = valorCasa / anos;
            porcentagem = (salario - (salario * 0.30));
            Console.WriteLine(porcentagem);

            if (prestacao > porcentagem)
            {
                Console.WriteLine("Empréstimo negado");
            } else
            {
                Console.WriteLine("Empréstimo autorizado");
            }
            Console.WriteLine($"O valor da prestação é de R${prestacao.ToString("F2", CultureInfo.InvariantCulture)} em {anos} anos.")



        }
    }
}
