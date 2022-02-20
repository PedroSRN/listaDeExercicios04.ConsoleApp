using System;

namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        //4 - Desenvolver um algoritmo que leia 5 valores inteiros e calcule e escreva a
        //média aritmética dos valores lidos, a quantidade de valores positivos e a
        //quantidade de valores negativos

        static void Main(string[] args)
        {
            
            int[] numero = new int[] {5,-5,10,2,-2};
            int resultado;
            int positivos = 0;
            int negativos = 0;

            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] > 0)
                {
                    positivos++;
                    
                }
                else if(numero[i] < 0)
                {
                    negativos++;
                    
                }
            }

            resultado = numero[0] + numero[1] + numero[2] + numero[3] + numero[4];
            resultado = resultado / 5;


            Console.WriteLine("Numeros positivos: " + positivos);
            Console.WriteLine("Numeros negativos: " + negativos);
            Console.WriteLine("A média Aritimética é: " + resultado);
            Console.ReadLine();
        }
    }
}
