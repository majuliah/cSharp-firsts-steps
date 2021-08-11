using System;

namespace AlistamentoMilitar
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, situacao;
            Console.WriteLine("Entre com a sua idade");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18 && idade <= 50)
            {
                Console.WriteLine("Pode se alistar!");
            }
            else
            {
                situacao = 18 - idade;
                Console.WriteLine("Faltam " + situacao + " para que você possa se alistar");
            }
        }
    }
}
