using System;

namespace Exercicios02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
         //- Desenhe um retângulo com asteriscos, onde as forem linhas pares escreva 
         // "A" e as linhas ímpares escreva "B
        {
            int largura, altura;

            Console.WriteLine("Digite o valor da Altura do retângulo: ");
            altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor da Largura do retânguloss: ");
            largura = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < largura; x++)
            {
                Console.WriteLine("");

                for (int y = 0; y < altura; y++)
                {
                    if (x %2 == 0) 
                    {
                        Console.Write("A");
                    }
                    if(x %2 == 1)
                    {
                        Console.Write("B");
                    }
                }
            }


            Console.ReadLine();
        }
    }
}
