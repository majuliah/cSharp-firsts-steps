using System;

namespace CalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoNascimento, idade;
            Console.WriteLine("Entre com o ano de nascimento");
            anoNascimento = int.Parse(Console.ReadLine());

            string date = DateTime.Now.ToString("yyyy");
            idade = int.Parse(date) - anoNascimento;

            if(idade > 16)
            {
                Console.WriteLine("Pode votar!");
            } else
            {
                Console.WriteLine("Não pode votar, neném");
            }

        }
    }
}
