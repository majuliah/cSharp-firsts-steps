using System;
using System.Globalization;

namespace Lanche1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pedido;
            int codigoItem, quantidadeItem;
            double total = 0, hotDog = 4.0, xSalada = 4.50,
                   xBacon = 5.0, torrada = 2.0, refri = 1.50;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("*********************************************");
            Console.WriteLine("**Entre com o item desejado e a quantidade.**");
            Console.WriteLine("**      1-   Hot-Dog   = R$4,00            **");
            Console.WriteLine("**      2-   X-Salada  = R$4,50            **");
            Console.WriteLine("**      3-   X-Bacon   = R$5,00            **");
            Console.WriteLine("**      4-   Torradas  = R$2,00            **");
            Console.WriteLine("**      5-   Refri     = R$1,50            **");
            Console.WriteLine("*********************************************");
            Console.WriteLine("*********************************************");
            Console.WriteLine("---------------------------------------------");

            pedido = Console.ReadLine().Split(' ');
            codigoItem = int.Parse(pedido[0]);
            quantidadeItem = int.Parse(pedido[1]);
            switch (codigoItem)
            {
                case 1 :
                    total = hotDog * quantidadeItem;
                    break;
                case 2 :
                    total = xSalada * quantidadeItem;
                    break;
                case 3 :
                    total = xBacon * quantidadeItem;
                    break;
                case 4 :
                    total = torrada * quantidadeItem;
                    break;
                case 5 :
                    total = refri * quantidadeItem;
                    break;
                default:
                    Console.WriteLine("Item não encontrado!");
                    break;
            }
            Console.WriteLine($"O seu pedido deu R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            
        }
    }
}