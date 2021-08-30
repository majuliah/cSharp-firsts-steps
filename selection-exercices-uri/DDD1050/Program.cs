using System;

namespace DDD1050
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************");
            Console.WriteLine("Entre com um DDD válido!");
            Console.WriteLine("     DDD 61             ");
            Console.WriteLine("     DDD 71             ");
            Console.WriteLine("     DDD 11             ");
            Console.WriteLine("     DDD 21             ");
            Console.WriteLine("     DDD 32             ");
            Console.WriteLine("     DDD 19             ");
            Console.WriteLine("     DDD 27             ");
            Console.WriteLine("     DDD 31             ");
            Console.WriteLine("************************");

            int ddd = int.Parse(Console.ReadLine());

            switch (ddd)
            {
                case 61:
                    Console.WriteLine("Brasília");
                    break;
                case 71:
                    Console.WriteLine("Salvador");
                    break;
                case 11:
                    Console.WriteLine("São Paulo");
                    break;
                case 21:
                    Console.WriteLine("Rio de Janeiro");
                    break;
                case 32:
                    Console.WriteLine("Juiz De Fora");
                    break;
                case 19:
                    Console.WriteLine("Campinas");
                    break;
                case 27:
                    Console.WriteLine("Vitória");
                    break;
                case 31:
                    Console.WriteLine("Belo Horizonte ou BeloRizonte");
                    break;
                default:
                    Console.WriteLine("DDD não reconhecido!");
                    break;
            }
        }
    }
}