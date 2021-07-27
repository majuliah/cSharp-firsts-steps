using System;
using System.Globalization;

namespace CalculaPercentualEmUmaEleicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int candidatoA, candidatoB, candidatoC, votosNulos, votosEmBranco, votosTotais;
            double percentualCandidatoA, percentualCandidatoB, percentualCandidatoC,
                   percentualNulo, percentualVotoEmBranco;

            Console.WriteLine("Entre com os votos do Candidato A: ");
            candidatoA = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com os votos do candidato B: ");
            candidatoB = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com os votos do candidato C");
            candidatoC = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o total de votos em branco");
            votosEmBranco = int.Parse(Console.ReadLine());
            Console.WriteLine("E por fim os votos nulos");
            votosNulos = int.Parse(Console.ReadLine());

            votosTotais = (candidatoA + candidatoB + candidatoC + votosEmBranco + votosNulos);

            percentualCandidatoA = ((candidatoA / votosTotais) * 100);
            percentualCandidatoB = ((candidatoB / votosTotais) * 100);
            percentualCandidatoC = ((candidatoC / votosTotais) * 100);
            percentualNulo = ((votosNulos / votosTotais) * 100);
            percentualVotoEmBranco = ((votosEmBranco / votosTotais) * 100);

            Console.WriteLine("Os candidatos A, B e C tiveram " + percentualCandidatoA + "% " + percentualCandidatoB + "% " + percentualCandidatoC + "% reespectivamente.");
            Console.WriteLine("Já os votos em branco e nulos tiveram " + percentualVotoEmBranco + "% e " + percentualNulo + "% também reespectivamente");
            Console.WriteLine("O total de votos foi: " + votosTotais);
        }
    }
}
