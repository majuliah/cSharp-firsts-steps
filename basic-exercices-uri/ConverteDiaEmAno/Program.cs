using System;

namespace ConverteDiaEmAno
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, ano, mes, dia, resto;
            Console.WriteLine("Entre com a idade em dias");
            idade = int.Parse(Console.ReadLine());

            ano = idade / 365;
            resto = idade % 365;
            mes = resto / 30;
            dia = resto % 30;

            Console.WriteLine(ano + " anos(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");
            
        }
    }
}
