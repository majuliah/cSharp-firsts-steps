using System;
using System.Globalization;

namespace VariasNotasComValidacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int  escolha = 1;
            double nota1, nota2, media;
            Console.WriteLine("Entre com as notas");

            while (escolha == 1)
            {
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while (nota1 < 0.0 || nota1 > 10.0)
                {
                    Console.WriteLine("Entre com uma nota válida");
                    nota1 = double.Parse(Console.ReadLine());
                }

                while (nota2 < 0.0 || nota2 > 10.0)
                {
                    Console.WriteLine("Entre com uma nota válida");
                    nota2 = double.Parse(Console.ReadLine());
                }

                media = (nota1 + nota2) / 2.0;
                Console.WriteLine($"A sua média foi: {media.ToString("F1",CultureInfo.InvariantCulture)}");
                
                Console.WriteLine("Deseja continuar?");
                Console.WriteLine("(1)SIM - (2)NÃO");
                escolha = int.Parse(Console.ReadLine());

                while (escolha != 1 && escolha != 2)
                {
                    Console.WriteLine("Deseja continuar?");
                    Console.WriteLine("(1)SIM - (2)NÃO");
                    escolha = int.Parse(Console.ReadLine());
                    
                }
                Console.WriteLine("Entre com as notas");
                
            }
        }
    }
}