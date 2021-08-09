using System;

namespace CalculaMulta
{
    class Program
    {
        static void Main(string[] args)
        {
            int velocidade, multa;
            Console.WriteLine("Entre com a velocidade");
            velocidade = int.Parse(Console.ReadLine());

            if (velocidade > 80)
            {
                multa = (velocidade - 80) * 5;
                Console.WriteLine("O valor da sua multa é: R$" + multa + ".00");
            } else
            {
                Console.WriteLine("Velocidade permitida");
            }
        }
    }
}
