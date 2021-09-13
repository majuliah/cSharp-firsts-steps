using System;

namespace Animal1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = Console.ReadLine().Split(' ');
            string animal, palavra1, palavra2;
            animal = palavras[0];
            palavra1 = palavras[1];
            palavra2 = palavras[2];


            switch (animal)
            {
                case ("vertebrado"):
                    if (palavra1 == "ave")
                    {
                        if (palavra2 == "carnivoro")
                        {
                            Console.WriteLine("águia");
                        }
                        else
                        {
                            Console.WriteLine("pombo");
                        }
                    }
                    else if (palavra1 == "mamifero")
                    {
                        if (palavra2 == "onivoro")
                        {
                            Console.WriteLine("homem");

                        }
                        else
                        {
                            Console.WriteLine("vaca");
                        }

                    } 
                    break;
                case "invertebrado":
                    if (palavra1 == "inseto")
                    {
                        if (palavra2 == "hematofago")
                        {
                            Console.WriteLine("pulga");
                        }
                        else
                        {
                            Console.WriteLine("lagarto");
                        }
                    }else if (palavra1 == "anelideo")
                    {
                        if (palavra2 == "hematofago")
                        {
                            Console.WriteLine("sanguessuga");
                        }
                        else
                        {
                            Console.WriteLine("minhoca");
                        }
                    }
                    break;
                default:
                    animal = " ";
                    break;
            }

        }
    }
}
