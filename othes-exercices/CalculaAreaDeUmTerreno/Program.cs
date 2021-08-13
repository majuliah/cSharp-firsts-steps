using System;
using System.Globalization;

namespace CalculaAreaDeUmTerreno
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, tamanhoTerreno;
            Console.WriteLine("Entre com a largura e o comprimento do terreno.");
            string[] terreno = Console.ReadLine().Split(' ');
            largura = double.Parse(terreno[0], CultureInfo.InvariantCulture);
            comprimento = double.Parse(terreno[1], CultureInfo.InvariantCulture);

            tamanhoTerreno = largura * comprimento;

            if (tamanhoTerreno < 100)
            {
                Console.WriteLine("Terreno Popular");

            } else if (tamanhoTerreno >= 100 & tamanhoTerreno > 500)
            {
                Console.WriteLine("Terreno master");
            } else
            {
                Console.WriteLine("Terreno VIP");
            }

            Console.WriteLine($"O tamanho de seu terreno é: {tamanhoTerreno}");
        }
    }
}
