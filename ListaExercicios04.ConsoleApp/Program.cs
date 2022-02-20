using System;

namespace ListaExercicios04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largura, altura;

            Console.WriteLine("Digite o valor da Altura do retângulo: ");
            altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor da Largura do retângulo: ");
            largura = Convert.ToInt32(Console.ReadLine());

            for( int x = 0; x < largura; x++)
            {  
                Console.WriteLine("");

                for(int y =0; y < altura; y++)
                {
                    Console.Write("*");
                }
            }


            Console.ReadLine();
        }
    }
}
