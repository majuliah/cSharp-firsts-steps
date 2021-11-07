using static System.Console;

namespace _18_QuatrVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[5];
            int[] vetorB = new int[5];
            string[] valoresAeB;
            int tamanhoPar = 0, tamanhoImpar = 0;
            int contA = 0, contB = 0;
            
            WriteLine("Entre com os valores do vetor A: ");
            valoresAeB = ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
            {
                vetorA[i] = int.Parse(valoresAeB[i]);
                if (vetorA[i] % 2 == 0)
                    tamanhoPar ++;
                else
                    tamanhoImpar++;
            }
            
            WriteLine("Agora entre com os valores do vetor B");
            valoresAeB = ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
            {
                vetorB[i] = int.Parse(valoresAeB[i]);

                if (vetorB[i] % 2 == 0)
                    tamanhoPar++;
                else
                    tamanhoImpar++;
            }

            int[] imparVetAeVetB = new int[tamanhoImpar];
            int[] parVetAeVetB = new int[tamanhoPar];

            for (int i = 0; i < 5; i++)
            {
                if (vetorA[i] % 2 == 0)
                {
                    parVetAeVetB[contA] = vetorA[i];
                    contA++;
                }
                else
                {
                    imparVetAeVetB[contB] = vetorA[i];
                    contB++;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (vetorB[i] % 2 == 0)
                {
                    parVetAeVetB[contA] = vetorB[i];
                    contA++;
                }
                else
                {
                    imparVetAeVetB[contB] = vetorB[i];
                    contB++;
                }
            }

            foreach (var numbr in parVetAeVetB)
                Write(numbr + " ");
            
            WriteLine(" Par ^  Impar v ");

            foreach (var number in imparVetAeVetB)
                Write(number + " ");
        }
    }
}
