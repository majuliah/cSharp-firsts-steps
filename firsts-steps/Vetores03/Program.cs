using System.Globalization;
using static System.Console;

namespace Vetores03
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            string[] nome, informacao;
            int[] idade;
            double[] altura;
            double alturaSoma = 0.0, idadeSoma = 0.0, media = 0.0, porcentagem = 0.0;
            
            WriteLine("Entre com o número de posições do array");
            index = int.Parse(ReadLine());
            nome = new string[index];
            idade = new int[index];
            altura = new double[index];
            
            WriteLine("Agora entre com Nome, idade e altura, reespectivamente");

            for (int i = 0; i < index; i++)
            {
                informacao = ReadLine().Split(' ');
                
                nome[i] = informacao[0];
                idade[i] = int.Parse(informacao[1]);
                altura[i] = double.Parse(informacao[2], CultureInfo.InvariantCulture);
                
                alturaSoma += altura[i];

                if (idade[i] < 16)
                    idadeSoma += idade[i];
                
            }

            media = alturaSoma / (double) index;
            porcentagem = idadeSoma / (double) index * 100.0;
            
            WriteLine($"A altura média é {media.ToString("F1", CultureInfo.InvariantCulture)}" + "\n" + $" Pessoas com menos de 16 anos: {porcentagem.ToString("F1", CultureInfo.InvariantCulture)}");

        }
    }
}
