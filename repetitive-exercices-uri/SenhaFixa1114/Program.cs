using System;

namespace SenhaFixa1114
{
    class Program
    {
        static void Main(string[] args)
        {
            int senhaCorreta = 2002, senha;
            Console.WriteLine("Entre com sua senha");
            senha = int.Parse(Console.ReadLine());

            while (senha != senhaCorreta)
            {
                Console.WriteLine("Senha inválida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Senha correta");
            
        }
    }
}