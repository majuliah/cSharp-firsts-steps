using System;

namespace NomeEsexo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] informacoes;
            string nome;
            char sexo;
            Console.WriteLine("Entre com seu nome e sexo");

            informacoes = Console.ReadLine().Split(' ');
            nome = informacoes[0];
            sexo = char.Parse(informacoes[1]);

            if (sexo == 'M')
            {
                Console.WriteLine("Ilmo Sr.");
            }
            else if (sexo == 'F')
            {
                Console.WriteLine("Ilma Sra.");
            }
            else
            {
                Console.WriteLine("Sexo não reconhecido");
            }
            
        }
    }
}