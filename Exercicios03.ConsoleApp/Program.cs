using System;

namespace Exercicios03.ConsoleApp
{
    internal class Program
    {
        //3 - Escreva um programa que contenha uma variável: horaAtual;
        //    Essa variável deverá conter a hora do dia e três mensagens deverão ser
        //    impressas na tela de acordo com a hora:
        //    “Bom dia”, “Boa tarde” ou “Boa noite”.
        static void Main(string[] args)
        {
            int horaAtual = 0;
          
            Console.WriteLine("Digite a hora atual: ");
            horaAtual = Convert.ToInt32(Console.ReadLine());

            
                if (horaAtual >= 1 && horaAtual < 12)
                {
                    Console.WriteLine("Bom Dia");

                }

                else if (horaAtual >= 12 && horaAtual < 18)
                {
                    Console.WriteLine("Boa Tarde");

                }
                else if (horaAtual >= 18 && horaAtual < 24)
                {
                    Console.WriteLine("Boa Noite");

                }
                
                else if (horaAtual > 24)
                {
                    Console.WriteLine("Horário inválido");
                }

            
            
            Console.ReadLine();
        }
    }
}
