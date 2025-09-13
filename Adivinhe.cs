/*Jogo de adivinhação no qual o usuário tem 10 tentativas para acertar um número entre 0 e 100. A cada tentativa, o programa diz se o jogador deve digitar um numero mais baixo ou mais alto. 
No final do programa, caso o jogador tenha acertado será mostrado em quantas tentativas ele conseguiu*/
using System;
using System.Diagnostics.Eventing.Reader;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numero = random.Next(1, 101);
            int tentativa = -1;
            int contador = 1;
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Digite um numero: ");
                tentativa = Convert.ToInt32(Console.ReadLine());
                while (tentativa < 0 || tentativa > 100)
                {
                    Console.WriteLine("Numero Invalido! o valor deve ser entre 0 e 100!");
                    tentativa = Convert.ToInt32(Console.ReadLine());
                }
                if (tentativa == numero)
                {
                    Console.WriteLine($"Parabens, você acertou na {contador}° tentativa!")
                            ; break;
                }
                else if (tentativa < numero)
                {
                    Console.WriteLine("Chute mais alto!");
                    
                }
                else if (tentativa > numero)
                {
                    Console.WriteLine("Chute mais baixo!:");
                    

                }
                contador++;

            }
            Console.WriteLine($"O numero correto era {numero}");
        }
    }
}

