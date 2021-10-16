using System;
using System.Globalization;

namespace Experiencias1094
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dados;
            int verificacoes, totalCobaias = 0, coelhos = 0, sapos = 0, ratos = 0, qtde;
            char animal;
            
            Console.WriteLine("Entre com a quantidade de verificações: ");
            verificacoes = int.Parse(Console.ReadLine());

            for (int i = 0; i < verificacoes; i++)
            {
                dados = Console.ReadLine().Split(' ');
                qtde = int.Parse(dados[0]);
                animal = char.Parse(dados[1]);

                if (animal == 'C')
                {
                    coelhos += qtde;
                }else if (animal == 'S')
                {
                    sapos += qtde;
                }
                else
                {
                    ratos += qtde;
                }

            }
            totalCobaias = coelhos + sapos + ratos;
            double percentualCoelho = (double)coelhos / totalCobaias;
            double percentualRatos = (double)ratos / totalCobaias;
            double percentualSapos = (double)sapos / totalCobaias;

            Console.WriteLine($"Total: {totalCobaias} cobaias" + "\n" + $" Total Coelhos: {coelhos}");
            Console.WriteLine($"Total de Ratos: {ratos}" + "\n" + $"Total Sapos: {sapos}");
            Console.WriteLine($"Percentual de coelhos: {percentualCoelho.ToString("F2", CultureInfo.InvariantCulture)}%");
            Console.WriteLine($"Percentual de coelhos: {percentualRatos.ToString("F2", CultureInfo.InvariantCulture)}%");
            Console.WriteLine($"Percentual de coelhos: {percentualSapos.ToString("F2", CultureInfo.InvariantCulture)}%");
        }
    }
}