using System;

namespace CalculaIdadeMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, cont = 0, soma = 0;
            double mediaIdades;

            Console.WriteLine("Entre com idades. Números negativos encerram a operação.");
            idade = int.Parse(Console.ReadLine());
            
            while (idade >= 0)
            {
                soma += idade;
                cont += 1;
                idade = int.Parse(Console.ReadLine());
            }

            if (cont == 0)
            {
                Console.WriteLine("Não é posível calcular.");
            }
            else
            {
                mediaIdades = (soma / cont);
                Console.WriteLine($"A média das idades é: {mediaIdades}");    
            }
        }
    }
}