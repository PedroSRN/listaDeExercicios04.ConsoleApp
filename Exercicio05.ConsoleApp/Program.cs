using System;

namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5 - Criar um jogo simplificado onde dois jogadores podem jogar dados;
            Regras: 
            • O jogo deverá solicitar o nome dos dois jogadores;ok

            O jogo terá 3 rodadas;ok

            O jogador que tirar o maior número nos dados nessas 3 rodadas vence;ok

            • Em caso de empate (onde os dois tiram o mesmo número), nenhum 
            jogador pontuará;ok

            • Os números permitidos vão de 0 a 6.
            A aplicação informará qual dos jogadores tirou o maior número*/

            string jogador1;
            string jogador2;
            int rodadas = 4;
            int resultadoJogador1;
            int resultadoJogador2;
            int vitoriaJogador1 = 0;
            int vitoriaJogador2 = 0;

            Console.WriteLine("-- DADOS THE GAME --");
            Console.Write("Digite o nome do jogador 1: ");
            jogador1 = Console.ReadLine();
            Console.Write("Digite o nome do jogador 2: ");
            jogador2 = Console.ReadLine();

            #region dados random
            Random numeroDado1 = new Random();
            int dado1 = numeroDado1.Next(0, 6);

            Random numeroDado2 = new Random();
            int dado2 = numeroDado2.Next(0, 6);

            Random numeroDado3 = new Random();
            int dado3 = numeroDado3.Next(0, 6);

            Random numeroDado4 = new Random();
            int dado4 = numeroDado4.Next(0, 6);

            Random numeroDado5 = new Random();
            int dado5 = numeroDado5.Next(0, 6);

            Random numeroDado6 = new Random();
            int dado6= numeroDado6.Next(0, 6);
            #endregion
            
            for (int i = 1; i < rodadas; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Rodada " + i);
                Console.WriteLine(" ");

                if (i == 1)
                {
                    

                    Console.WriteLine(jogador1 + " fez o numero de pontos de: " + dado1);
                    Console.WriteLine(" ");
                    Console.WriteLine(jogador2 + " fez o numero de pontos de: " + dado2);
                    Console.WriteLine(" ");

                    if (dado1 > dado2)
                    {
                        Console.WriteLine(jogador1 + " Ganhou a rodada");
                         vitoriaJogador1++;
                    }
                    else if (dado2 > dado1)
                    {
                        Console.WriteLine(jogador2 + " Ganhou a rodada");
                        vitoriaJogador2++;
                    }
                    else if (dado1 == dado2)
                    {
                        dado1 = 0;
                        dado2 = 0;
                        Console.WriteLine("A Rodada empatou");
                    }
                    Console.WriteLine("--------------------------------------");
                }

                if (i == 2)
                {
                    Console.WriteLine(jogador1 + " fez o numero de pontos de: " + dado3);
                    Console.WriteLine(" ");
                    Console.WriteLine(jogador2 + " fez o numero de pontos de: " + dado4);
                    Console.WriteLine(" ");

                    if (dado3 > dado4)
                    {
                        Console.WriteLine(jogador1 + " Ganhou a rodada");
                        vitoriaJogador1++;
                    }
                    else if (dado4 > dado3)
                    {
                        Console.WriteLine(jogador2 + " Ganhou a rodada");
                        vitoriaJogador2++;
                    }
                    else if (dado3 == dado4)
                    {
                        dado3 = 0;
                        dado4 = 0;
                        Console.WriteLine("A Rodada empatou");
                    }
                    Console.WriteLine("--------------------------------------");
                }

                if (i == 3)
                {
                    Console.WriteLine(jogador1 + " fez o numero de pontos de: " + dado5);
                    Console.WriteLine(" ");
                    Console.WriteLine(jogador2 + " fez o numero de pontos de: " + dado6);
                    Console.WriteLine(" ");

                    if (dado5 > dado6)
                    {
                        Console.WriteLine(jogador1 + " Ganhou a rodada");
                        vitoriaJogador1++;
                    }
                    else if (dado6 > dado5)
                    {
                        Console.WriteLine(jogador2 + " Ganhou a rodada");
                        vitoriaJogador2++;
                    }
                    if (dado5 == dado6)
                    {
                        dado5 = 0;
                        dado6 = 0;
                        Console.WriteLine("A Rodada empatou");
                    }
                    Console.WriteLine("--------------------------------------");
                }

            }

            Console.WriteLine(" ");
            Console.WriteLine("Resultado");
            Console.WriteLine(" ");
            


            if(vitoriaJogador1 > vitoriaJogador2)
            {
                Console.WriteLine(jogador1 + " GANHOU");
            }
            else if (vitoriaJogador2 > vitoriaJogador1)
            {
                Console.WriteLine(jogador2 + " GANHOU");
            }
            else if (vitoriaJogador1 == vitoriaJogador2)
            {
                Console.WriteLine("A partida empatou");
            }

            Console.ReadLine();
        }
    }
}
